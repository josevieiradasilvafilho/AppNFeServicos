using System;
using System.Windows.Forms;

namespace App.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            FrmLogin frmShow = new FrmLogin();

            frmShow.ShowIcon = false;
            frmShow.MaximizeBox = false;
            frmShow.MinimizeBox = false;
            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            

            frmShow.StartPosition = FormStartPosition.CenterScreen;
            this.StartPosition = FormStartPosition.CenterScreen;

            frmShow.txtPassword.PasswordChar = '*';
            this.txtPassword.PasswordChar = '*';
        }

        


        private void button2_Click(object sender, EventArgs e)
        {

            

            FrmPrincipal frmShow = new FrmPrincipal();
            FrmLogin frmUnShow = new FrmLogin();

            this.Hide();

            frmShow.Closed += (s, args) => this.Close();
            frmShow.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                                "Deseja realmente fechar a aplicação?"
                                                , "Fechar"
                                                , MessageBoxButtons.YesNo
                                                , MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
