using App.BLL;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace App.UI
{
    public partial class FrmCidades : Form
    {
        public FrmCidades()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        }

        public String ExportarvalortxtId
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

        public String ExportarvalortxtCidade
        {
            get { return txtCidade.Text; }
            set { txtCidade.Text = value; }
        }

        public String ExportarvalortxtCodigo
        {
            get { return txtCodigo.Text; }
            set { txtCodigo.Text = value; }
        }

        public String ExportarvalortxtUF
        {
            get { return txtUF.Text; }
            set { txtUF.Text = value; }
        }

        public void PulaProxCampoTabIndex(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SendKeys.Send("{TAB}");
            }
        }

        public void UpdtateDatagredView()
        {
            DateTime oThisDay = DateTime.Now;

           
            dtGCidades.DataSource = new 
                Cidades(1,@"", @"", @"", oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM (
                                                 SELECT 
                                                CIDADES_ID AS ID
                                                , CIDADES_NOME AS CIDADE
                                                , CIDADES_CODIGO AS CODIGO
                                                , CIDADES_UF AS UF
                                                , CAST(Cidades_DtCadastro AS NVARCHAR(20)) AS CADASTRO
                                                , CAST(Cidades_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇÃO 
                                                FROM CIDADES)");

            
            dtGCidades.AutoResizeColumns();
            dtGCidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGCidades.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            dtGCidades.Sort(dtGCidades.Columns[4], ListSortDirection.Descending);

        }

        public void UpdtateDatagredViewSearch(string cidades_Nome)
        {
            DateTime oThisDay = DateTime.Now;

            dtGCidades.DataSource = new
                Cidades(1,@"", @"", @"", oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM ("
                                                + @"SELECT CIDADES_ID AS ID"
                                                + @", CIDADES_NOME AS CIDADE"
                                                + @", CIDADES_CODIGO AS CODIGO"
                                                + @", CIDADES_UF AS UF"
                                                + @", CAST(Cidades_DtCadastro AS NVARCHAR(20)) AS CADASTRO"
                                                + @", CAST(Cidades_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇÃO "
                                                + @"FROM CIDADES "
                                                + @"WHERE (CIDADES_NOME LIKE '%" + cidades_Nome + @"%'))");
            dtGCidades.AutoResizeColumns();
            dtGCidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGCidades.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            dtGCidades.Sort(dtGCidades.Columns[4], ListSortDirection.Descending);

        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            FrmCidades frm = new FrmCidades();

            frm.ShowIcon = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Size = new Size(766, 438);
            frm.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.MaximizeBox = false;

            //ATUALIZAR DATAGRID VIEW DE CIDADES
            UpdtateDatagredView();
        }

        public void AtualizarDados(string Opcao)
        {
            try
            {

            DateTime oThisDay = DateTime.Now;

            if (String.IsNullOrEmpty(txtId.Text)) txtId.Text = @"1";
                //Instanciar dados de inclusão para validação
                var oCidades = new Cidades(
                                        Convert.ToInt32(txtId.Text)
                                        , Convert.ToString(txtCidade.Text).Trim()
                                        , Convert.ToString(txtCodigo.Text).Trim()
                                        , Convert.ToString(txtUF.Text).Trim()
                                        , oThisDay
                                        , oThisDay
                                        , @"Inserir"
                                        );

                //VALIDAR DADOS DO USUARIO
                oCidades.SetDados();

                switch (Opcao)
                {
                    case @"Inserir":
                        //INSERIR USUÁRIOS
                        if (MessageBox.Show("Confirma a Inclusão?", @"Usuarios-Erros(Inserir)!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oCidades.Inserir();
                        //LIMPAR CAMPOS
                            txtId.Clear();
                            txtCidade.Clear();
                            txtCodigo.Clear();
                            txtUF.Clear();

                        }

                        break;

                    case @"Atualizar":
                        //INSERIR USUÁRIOS
                        if (MessageBox.Show("Confirma a Atualização?", @"Usuarios-Erros(Atualizar)!",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oCidades.Atualizar();
                            //LIMPAR CAMPOS
                            txtId.Clear();
                            txtUF.Clear();
                            txtCidade.Clear();
                            txtCodigo.Clear();
                        }

                        break;

                    case @"Excluir":
                        //INSERIR USUÁRIOS
                        if (MessageBox.Show("Confirma a Exclusão?", @"Usuarios-Erros(Excluir)!",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oCidades.Remover();
                        //LIMPAR CAMPOS
                            txtId.Clear();
                            txtCidade.Clear();
                            txtCodigo.Clear();
                            txtUF.Clear();
                        }

                        break;

                    case @"Pesquisar":

                        break;

                    default:
                        break;
                }   

                //ATUALIZAR DATAGRID VIEW DE CIDADES
                UpdtateDatagredView();

                
                //FOCO
                txtCidade.Focus();
            
            }
            catch (Exception ex)
            
            {
                string sErr = Convert.ToString(ex);

                switch (sErr.Contains("UNIQUE constraint failed"))
                {
                    case true:

                        MessageBox.Show(@"Registro Existente! ", @"Usuarios-Erros(Inserção)!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);

                        
                        break;
                   
                    default:

                        MessageBox.Show(ex.Message , @"Usuarios-Erros(Inserção)!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);

                        break;
                }

                txtCidade.Focus();

            }
        }

        //ATUALIZAR QUANDO CLICAR UMA VEZ
        private void dtGCidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[0].Value);
            txtCidade.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[1].Value);
            txtCodigo.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[2].Value);
            txtUF.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[3].Value);
        }

        //ATUALIZAR 
        private void dtGCidades_CellContentRow_Enter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[0].Value);
            txtCidade.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[1].Value);
            txtCodigo.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[2].Value);
        }

        //ATUALIZAR QUANDO DER UM DUPLO CLICK
        private void dtGCidades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[0].Value);
            txtCidade.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[1].Value);
            txtCodigo.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[2].Value);
        }

        //ATUALIZAR 
        private void dtGCidades_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[0].Value);
            txtCidade.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[1].Value);
            txtCodigo.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[2].Value);
            txtUF.Text = Convert.ToString(dtGCidades.CurrentRow.Cells[3].Value);
        }
         //
        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Inserir");
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Atualizar");
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Excluir");
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            UpdtateDatagredViewSearch(txtCidade.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsIncluir_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Inserir");
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Atualizar");
        }

        private void ts_Remover_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Excluir");
        }

        private void ts_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsInserir_Click(object sender, EventArgs e)
        {
            AtualizarDados("Inserir");
        }

        private void tsSalvar_Click_1(object sender, EventArgs e)
        {
            AtualizarDados("Atualizar");
;        }

        private void ts_Remover_Click_1(object sender, EventArgs e)
        {
            AtualizarDados("Excluir");
        }

        private void ts_Sair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
