using App.BLL;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace App.UI
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
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
            //dtGUsuarios.DataSource = new Dominio().GetUsuarios();
            DateTime oThisDay = DateTime.Now;

            dtGUsuarios.DataSource = new Usuarios(1, @"", @"", @"", @"", true, oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM (" 
                                                 + "SELECT [Usuarios_Id] AS ID" +
                                                 ", [Usuarios_Usuario] AS USUARIO" +
                                                 ", [Usuarios_Email] AS EMAIL" +
                                                 ", CAST(Usuarios_DtInclusao AS NVARCHAR(20)) AS INCLUSÃO" +
                                                 ", CAST(Usuarios_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇAO" +
                                                 ", CASE Usuarios_Administrador WHEN 'True' THEN 'Administrador' WHEN 'False' THEN 'Usuario' ELSE 'Usuário' END Permissao FROM USUARIOS)");
            
            dtGUsuarios.AutoResizeColumns();
            dtGUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGUsuarios.Columns[4].SortMode = DataGridViewColumnSortMode.Automatic;
            dtGUsuarios.Sort(dtGUsuarios.Columns[4], ListSortDirection.Descending);

            txtSenha.Clear();
            txtConfirmarSenha.Clear();

        }

        public void UpdtateDatagredViewSearch(string usuarios_Usuario)
        {
            DateTime oThisDay = DateTime.Now;

            dtGUsuarios.DataSource = new Usuarios(1, @"", @"", @"", @"", true, oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM ("
                                                 + @"SELECT [Usuarios_Id] AS ID"
                                                 +@", [Usuarios_Usuario] AS USUARIO"
                                                 +@", [Usuarios_Email] AS EMAIL"
                                                 +@", CAST(Usuarios_DtInclusao AS NVARCHAR(20)) AS INCLUSÃO"
                                                 +@", CAST(Usuarios_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇAO"
                                                 +@", CASE Usuarios_Administrador WHEN 'True' THEN 'Administrador' WHEN 'False' THEN 'Usuario' ELSE 'Usuário' END Permissao FROM USUARIOS "
                                                 +@"WHERE (Usuarios_Usuario LIKE '%" + usuarios_Usuario + @"%'))");
            dtGUsuarios.AutoResizeColumns();
            dtGUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGUsuarios.Columns[4].SortMode = DataGridViewColumnSortMode.Automatic;
            dtGUsuarios.Sort(dtGUsuarios.Columns[4], ListSortDirection.Descending);

            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                txtEmail.Clear();
                txtSenha.Clear();
                txtConfirmarSenha.Clear();
                cmbTipoPermissao.SelectedIndex = -1;
            }
                

        }

        public void AtualizarDados(string Opcao)
        {
            try
            {
            
                DateTime oThisDay = DateTime.Now;

                bool TipoPermissao;

                if (cmbTipoPermissao.SelectedIndex == -1)
                {
                    cmbTipoPermissao.SelectedIndex = cmbTipoPermissao.FindString(@"Usuario");//selectionar cliente caso o usuário deixe de selecionar 
                    TipoPermissao = false;
                }
                else
                {
                    switch (cmbTipoPermissao.SelectedItem.ToString())
                    {
                        case @"Administrador":
                            TipoPermissao = true;
                            break;
                        case @"Usuario":
                            TipoPermissao = false;
                            break;
                        default:
                            cmbTipoPermissao.SelectedIndex = cmbTipoPermissao.FindString(@"Usuario");//selectionar cliente caso o usuário deixe de selecionar
                            TipoPermissao = false;
                            break;
                    }

                }

            if (String.IsNullOrEmpty(txtId.Text)) txtId.Text = @"1";

                //Instanciar dados de inclusão para validação
                var oUsuarios = new Usuarios(Convert.ToUInt16(txtId.Text)
                    , Convert.ToString(txtUsuario.Text).Trim()
                    , Convert.ToString(txtEmail.Text).Trim()
                    , txtSenha.Text
                    , txtConfirmarSenha.Text
                    , TipoPermissao
                    , oThisDay
                    , oThisDay
                    , Opcao
                    );

                //VALIDAR DADOS DO USUARIO
                oUsuarios.SetDados();

                switch (Opcao)
                {
                    case @"Inserir":
                        if (MessageBox.Show("Confirma a Inclusão?", @"Usuarios-Erros(Inserir)!",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oUsuarios.Inserir();

                            //LIMPAR CAMPOS
                            txtId.Clear();
                            txtUsuario.Clear();
                            txtEmail.Clear();
                            txtSenha.Clear();
                            txtConfirmarSenha.Clear();
                            cmbTipoPermissao.SelectedIndex = -1;

                        }

                        break;

                    case @"Atualizar":
                        //Atualizar 
                        if (MessageBox.Show("Confirma a Atualização?", @"Usuarios-Erros(Atualizar)!",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oUsuarios.Atualizar();
                            //LIMPAR CAMPOS
                            txtId.Clear();
                            txtUsuario.Clear();
                            txtEmail.Clear();
                            txtSenha.Clear();
                            txtConfirmarSenha.Clear();
                            cmbTipoPermissao.SelectedIndex = -1;
                        }

                        break;

                    case @"Excluir":
                        //INSERIR USUÁRIOS
                        if (MessageBox.Show("Confirma a Exclusão?", @"Usuarios-Erros(Excluir)!",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oUsuarios.Remover();
                            //LIMPAR CAMPOS
                            txtId.Clear();
                            txtUsuario.Clear();
                            txtEmail.Clear();
                            txtSenha.Clear();
                            txtConfirmarSenha.Clear();
                            cmbTipoPermissao.SelectedIndex = -1;
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
                txtUsuario.Focus();
            
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

                        MessageBox.Show(ex.Message, @"Usuarios-Erros(Inserção)!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);

                        break;
                }

                txtUsuario.Focus();
            }
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {


            FrmUsuarios frm = new FrmUsuarios();

            frm.ShowIcon = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Size = new Size(766, 438);
            frm.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            cmbTipoPermissao.Items.Add("Administrador");
            cmbTipoPermissao.Items.Add("Usuario");

            txtSenha.PasswordChar = '*';
            txtConfirmarSenha.PasswordChar = '*';
            
            //Populando Datagred View
            UpdtateDatagredView();
            
        }
        private void dtGUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtUsuario.Text))
                {
                    txtEmail.Clear();
                    txtSenha.Clear();
                    txtConfirmarSenha.Clear();
                    cmbTipoPermissao.SelectedIndex = -1;
                }

                txtId.Text = Convert.ToString(dtGUsuarios.CurrentRow.Cells[0].Value);
                txtUsuario.Text = Convert.ToString(dtGUsuarios.CurrentRow.Cells[1].Value);
                txtEmail.Text = Convert.ToString(dtGUsuarios.CurrentRow.Cells[2].Value);

                cmbTipoPermissao.SelectedIndex = cmbTipoPermissao.FindString(Convert.ToString(dtGUsuarios.CurrentRow.Cells[5].Value));
            }
            catch
            {

                //throw;
            }
        }            
        private void dtGUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = Convert.ToString(dtGUsuarios.CurrentRow.Cells[0].Value);
            txtEmail.Text = Convert.ToString(dtGUsuarios.CurrentRow.Cells[1].Value);
        }
        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Inserir");
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Excluir");
        }
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AtualizarDados(@"Atualizar");
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            UpdtateDatagredViewSearch(txtUsuario.Text);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AtualizarDados(@"Excluir");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoPermissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTipoPermissao_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //MessageBox.Show("Confirma a Inclusão?", @"Usuarios-Erros(Inserir)!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }
           
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
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
