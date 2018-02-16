using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App.UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            //this.Icon = new Icon("");
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios oFrmUsuarios = new FrmUsuarios();
            oFrmUsuarios.ShowDialog();
        }

        private void tipoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoClientes oFrmTipoClientes = new FrmTipoClientes();

            oFrmTipoClientes.ShowDialog();
        }

        private void regimeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegimeClientes oFrmRegimeClientes = new FrmRegimeClientes();

            oFrmRegimeClientes.ShowDialog();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidades oFrmCidades = new FrmCidades();

            oFrmCidades.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes oFrmClientes = new FrmClientes();

            oFrmClientes.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void tsInserir_Click(object sender, EventArgs e)
        {
            
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", @"Main()!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tipoDeLogradouroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoLogradouros oFrmTipoLogradouros = new FrmTipoLogradouros();

            oFrmTipoLogradouros.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string teste = Application.StartupPath;
                //Properties.Resources.ResourceManager.BaseName()
            MessageBox.Show(teste);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string teste = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("\\bin\\Debug", "") + "Resources";
            string teste = Directory.GetCurrentDirectory();
            //Properties.Resources.ResourceManager.BaseName()
            MessageBox.Show(teste);
        }
    }
}
