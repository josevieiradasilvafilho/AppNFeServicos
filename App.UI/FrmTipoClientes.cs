using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.BLL;

namespace App.UI
{
    public partial class FrmTipoClientes : Form
    {
        public FrmTipoClientes()
        {
            InitializeComponent();
        }

        public String ExportarvalortxtId
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

        public String ExportarvalortxtTipo
        {
            get { return txtTipo.Text; }
            set { txtTipo.Text = value; }
        }

        private void TipoClientes_Load(object sender, EventArgs e)
        {

            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.Size = new Size(766, 438);

            UpdtateDatagredView();

        }

        public void UpdtateDatagredView()
        {
            //dtGUsuarios.DataSource = new Dominio().GetUsuarios();
            DateTime oThisDay = DateTime.Now;

            dtG.DataSource = new TipoClientes(1, @"", oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM ("
                                                 + @"SELECT TipoClientes_Id AS ID "
                                                 + @",TipoClientes_Nome AS TIPO"
                                                 + @",CAST(TipoClientes_DtCadastro AS NVARCHAR(20)) AS INCLUSÃO"
                                                 + @",CAST(TipoClientes_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇAO "
                                                 + @"FROM TipoClientes )");

            dtG.AutoResizeColumns();
            dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtG.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            dtG.Sort(dtG.Columns[3], ListSortDirection.Descending);

            txtId.Clear();
            txtTipo.Clear();
            

        }

        public void UpdtateDatagredViewSearch(string tipoClientes_Nome)
        {
            DateTime oThisDay = DateTime.Now;

            /*try
            {*/

                dtG.DataSource = new TipoClientes(1, @"", oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM ("
                                                     + @"SELECT TipoClientes_Id AS ID "
                                                     + @",TipoClientes_Nome AS TIPO"
                                                     + @",CAST(TipoClientes_DtCadastro AS NVARCHAR(20)) AS INCLUSÃO"
                                                     + @",CAST(TipoClientes_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇAO "
                                                     + @"FROM TipoClientes "
                                                     + @"WHERE (TipoClientes_Nome LIKE '%" + tipoClientes_Nome + @"%'))");
                dtG.AutoResizeColumns();
                dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtG.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
                dtG.Sort(dtG.Columns[3], ListSortDirection.Descending);

                if (String.IsNullOrEmpty(txtTipo.Text))
                {
                    txtId.Clear();
                    txtTipo.Clear();
                }

            /*}
            catch (Exception ex)
            {
                string sErr = Convert.ToString(ex);

                switch (sErr.Contains("UNIQUE constraint failed"))
                {
                    case true:

                        MessageBox.Show(@"Registro Existente! ", @"TipoClientes-Erros(Inserção)!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);

                        break;

                    default:

                        MessageBox.Show(ex.Message, @"TipoClientes-Erros(Inserção)!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);

                        break;
                }

                txtTipo.Focus();
            }*/

        }

        public bool backspace = false;

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

        private void dtG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Size = new Size(726, 280);
            txtId.Text = Convert.ToString(dtG.CurrentRow.Cells[0].Value);
            txtTipo.Text = Convert.ToString(dtG.CurrentRow.Cells[1].Value);
        }

        public void AtualizarDados(string Opcao)
        {
            try
            {

                DateTime oThisDay = DateTime.Now;

                if (String.IsNullOrEmpty(txtId.Text)) txtId.Text = @"1";
                
                //Instanciar dados de inclusão para validação
                var oTipoClientes = new TipoClientes(
                    Convert.ToInt32(txtId.Text)
                    , Convert.ToString(txtTipo.Text).Trim()
                    , oThisDay
                    , oThisDay
                    , Opcao
                    );

                //VALIDAR DADOS DO USUARIO
                oTipoClientes.SetDados();

                switch (Opcao)
                {
                    case @"Inserir":
                        if (MessageBox.Show("Confirma a Inclusão?", @"TipoClientes-Erros(Inserir)!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oTipoClientes.Inserir();

                            //LIMPAR CAMPOS
                            txtId.Clear();
                            txtTipo.Clear();
                            
                        }

                        break;

                    case @"Atualizar":
                        //Atualizar 
                        if (MessageBox.Show("Confirma a Atualização?", @"Usuarios-Erros(Atualizar)!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oTipoClientes.Atualizar();
                            //LIMPAR CAMPOS
                            txtId.Clear();
                            txtTipo.Clear();
                            
                        }

                        break;

                    case @"Excluir":
                        //INSERIR USUÁRIOS
                        if (MessageBox.Show("Confirma a Exclusão?", @"Usuarios-Erros(Excluir)!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oTipoClientes.Excluir();
                            //LIMPAR CAMPOS
                            txtId.Clear();
                            txtTipo.Clear();
                            
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
                txtTipo.Focus();
            
            }
            catch (Exception ex)
            {
                string sErr = Convert.ToString(ex);

                switch (sErr.Contains("UNIQUE constraint failed"))
                {
                    case true:

                        MessageBox.Show(@"Registro Existente! ", @"TipoClientes-Erros(Inserção)!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);

                        break;

                    default:

                        MessageBox.Show(ex.Message, @"TipoClientes-Erros(Inserção)!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);

                        break;
                }

                txtTipo.Focus();
            }
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Inserir");
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Atualizar");
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Excluir");
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            UpdtateDatagredViewSearch(txtTipo.Text);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
