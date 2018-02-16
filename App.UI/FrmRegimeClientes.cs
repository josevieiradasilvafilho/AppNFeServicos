using App.BLL;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace App.UI
{

    public partial class FrmRegimeClientes : Form
    {
        public bool backspace = false;

        public FrmRegimeClientes()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        }

        public String ExportarvalortxtCodigo
        {
            get { return txtCodigo.Text; }
            set { txtCodigo.Text = value; }
        }
        public String ExportarvalortxtNome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }
        public String ExportarvalortxtId
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }
        public String ExportarvalortxtDeducoes
        {
            get { return txtDeducoes.Text; }
            set { txtDeducoes.Text = value; }
        }
        public String ExportarvalortxtTributo
        {
            get { return txtTributo.Text; }
            set { txtTributo.Text = value; }
        }

        public void PulaProxCampoTabIndex(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SendKeys.Send("{TAB}");
            }

            if (e.KeyCode == Keys.Back)
            {
                //MessageBox.Show("pressionou BackSpace");
                backspace = true;
            }
        }

        private void FrmRegimeClientes_Load(object sender, EventArgs e)
        {

            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.Size = new Size(766, 438);

            //this.maskedTextBox1.Mask = "R$ 999.999,00";


            UpdtateDatagredView();

        }

        public void UpdtateDatagredView()
        {
            //dtGUsuarios.DataSource = new Dominio().GetUsuarios();
            DateTime oThisDay = DateTime.Now;

            dtG.DataSource = new RegimeClientes(1, @"", 1, @"", 1, oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM ("
                                                    + @"SELECT RegimeClientes_Id AS ID "
                                                    + @",RegimeClientes_Nome AS [REGIME_TRIBUTÁRIO]"
                                                    + @",RegimeClientes_Codigo AS CODIGO"
                                                    + @",RegimeClientes_Tributo AS TRIBUTO"
                                                    + @",CAST(RegimeClientes_Deducoes AS NVARCHAR(9,2)) AS DEDUÇÕES"
                                                    + @",CAST(RegimeClientes_DtCadastro AS NVARCHAR(20)) AS INCLUSÃO"
                                                    + @",CAST(RegimeClientes_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇAO "
                                                    + @"FROM RegimeClientes )");

           
            dtG.AutoResizeColumns();
            dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtG.Columns[5].SortMode = DataGridViewColumnSortMode.Automatic;
            dtG.Sort(dtG.Columns[5], ListSortDirection.Descending);

            txtCodigo.Clear();
            txtDeducoes.Clear();
            txtId.Clear();
            txtNome.Clear();
            txtTributo.Clear();

        }

        public void UpdtateDatagredViewSearch(string regimeClientes_Nome)
        {
            DateTime oThisDay = DateTime.Now;

            dtG.DataSource = new RegimeClientes(1, @"", 1, @"", 1, oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM ("
                                                    + @"SELECT RegimeClientes_Id AS ID "
                                                    + @",RegimeClientes_Nome AS [REGIME_TRIBUTÁRIO]"
                                                    + @",RegimeClientes_Codigo AS CODIGO"
                                                    + @",RegimeClientes_Tributo AS TRIBUTO"
                                                    + @",CAST(RegimeClientes_Deducoes AS NVARCHAR(9,2)) AS DEDUÇÕES"
                                                    + @",CAST(RegimeClientes_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇAO "
                                                    + @",CAST(RegimeClientes_DtCadastro AS NVARCHAR(20)) AS INCLUSÃO"
                                                    + @"FROM RegimeClientes "
                                                    + @"WHERE (RegimeClientes_Nome LIKE '%" + regimeClientes_Nome + @"%'))");
            //+ @",CAST(RegimeClientes_DtCadastro AS NVARCHAR(20)) AS INCLUSÃO"

            dtG.AutoResizeColumns();
            dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtG.Columns[5].SortMode = DataGridViewColumnSortMode.Automatic;
            dtG.Sort(dtG.Columns[5], ListSortDirection.Descending);

            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Clear();
                txtDeducoes.Clear();
                txtId.Clear();
                txtNome.Clear();
                txtTributo.Clear();

            }


        }

        public void AtualizarDados(string Opcao)
        {
            try
            {
            
                DateTime oThisDay = DateTime.Now;

                if (String.IsNullOrEmpty(txtId.Text)) txtId.Text = @"1";
                
                //Instanciar dados de inclusão para validação
                var oRegimeClientes = new RegimeClientes(
                                                        Convert.ToInt32(txtId.Text)
                                                        , Convert.ToString(txtNome.Text).Trim()
                                                        , Convert.ToInt32(txtCodigo.Text)
                                                        , Convert.ToString(txtTributo.Text)
                                                        , Convert.ToDecimal(txtDeducoes.Text)
                                                        , oThisDay
                                                        , oThisDay
                                                        , Opcao
                                                        );

                //VALIDAR DADOS DO USUARIO
                oRegimeClientes.SetDados();

                switch (Opcao)
                {
                    case @"Inserir":
                        if (MessageBox.Show("Confirma a Inclusão?", @"Usuarios-Erros(Inserir)!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oRegimeClientes.Inserir();

                            //LIMPAR CAMPOS
                            txtCodigo.Clear();
                            txtDeducoes.Clear();
                            txtId.Clear();
                            txtNome.Clear();
                            txtTributo.Clear();

                        }

                        break;

                    case @"Atualizar":
                        //Atualizar 
                        if (MessageBox.Show("Confirma a Atualização?", @"Usuarios-Erros(Atualizar)!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oRegimeClientes.Atualizar();
                            //LIMPAR CAMPOS
                            txtCodigo.Clear();
                            txtDeducoes.Clear();
                            txtId.Clear();
                            txtNome.Clear();
                            txtTributo.Clear();
                        }

                        break;

                    case @"Excluir":
                        //INSERIR USUÁRIOS
                        if (MessageBox.Show("Confirma a Exclusão?", @"Usuarios-Erros(Excluir)!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oRegimeClientes.Excluir();
                            //LIMPAR CAMPOS
                            txtCodigo.Clear();
                            txtDeducoes.Clear();
                            txtId.Clear();
                            txtNome.Clear();
                            txtTributo.Clear();
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
                txtNome.Focus();

            }
            catch (Exception ex)

            {

                string sErr = Convert.ToString(ex);

                if (sErr.Contains(@"UNIQUE constraint failed"))
                {
                    MessageBox.Show(@"Registro Existente! ", @"NotasFiscais-Erros(Inserção)!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sErr.Contains(@"Input string was not in a correct format."))
                {
                    MessageBox.Show(@"Dados Em Branco! ", @"NotasFiscais-Erros(Inserção)!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, @"NotasFiscais-Erros(Inserção)!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtNome.Focus();

            }
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Inserir");
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Excluir");
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Atualizar");
        }
        
        public static bool IsNumber(Keys key)
        {
            string num = key.ToString().Substring(key.ToString().Length - 1);
            Int64 i64;
            if (Int64.TryParse(num, out i64))
            {
                return true;
            }
            return false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDeducoes_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            

        }
        
        private void txtDeducoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (backspace)
            {
                //string TestString = txtDeducoes.Text;
                txtDeducoes.Clear();
                backspace = false;
            }

            int i;
            if (int.TryParse(e.KeyChar.ToString(), out i) || (e.KeyChar.ToString())=="." || (e.KeyChar.ToString()) == ",")
            {
                
            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDeducoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTributo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTributo_KeyPress(object sender, KeyPressEventArgs e)
        {

            string str = txtTributo.Text;

            if (backspace)
            {
               
                txtTributo.Clear();
                backspace = false;
            }


            if ( (str.Length >=1) )
            {
                e.Handled = true;
                return;
            }
            
        }

        private void dtG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Convert.ToString(dtG.CurrentRow.Cells[0].Value);
            txtNome.Text = Convert.ToString(dtG.CurrentRow.Cells[1].Value);
            txtCodigo.Text = Convert.ToString(dtG.CurrentRow.Cells[2].Value);
            txtDeducoes.Text = Convert.ToString(dtG.CurrentRow.Cells[4].Value);
            txtTributo.Text = Convert.ToString(dtG.CurrentRow.Cells[3].Value);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            UpdtateDatagredViewSearch(txtNome.Text);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsInserir_Click(object sender, EventArgs e)
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
    }
}
