using App.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI
{
    public partial class FrmTipoLogradouros : Form
    {
        public FrmTipoLogradouros()
        {
            InitializeComponent();
        }

        public String ExportarvalortxtID
        {
            get { return txtID.Text; }
            set { txtID.Text = value; }
        }
        public String ExportarvalortxtCodigo
        {
            get { return txtCodigo.Text; }
            set { txtCodigo.Text = value; }
        }
        public String ExportarvalortxtLogradouro
        {
            get { return txtLogradouro.Text; }
            set { txtLogradouro.Text = value; }
        }
        public String ExportarvalortxtAbreviatura
        {
            get { return txtAbreviature.Text; }
            set { txtAbreviature.Text = value; }
        }


        public void UpdtateDatagredView()
        {
            DateTime oThisDay = DateTime.Now;


            dtG.DataSource = new TiposLogradouros(1, 1,@"", @"",oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM (
                                                 SELECT 
                                                TipoLogradouros_ID AS ID
                                                , TipoLogradouros_CODIGO AS CODIGO
                                                , TipoLogradouros_ABREVIATURA AS ABREVIATURA
                                                , TipoLogradouros_LOGRADOURO AS LOGRADOURO
                                                , CAST(TipoClientes_DtCadastro AS NVARCHAR(20)) AS CADASTRO
                                                , CAST(TipoClientes_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇÃO 
                                                FROM TipoLogradouros)");


            dtG.AutoResizeColumns();
            dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtG.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            dtG.Sort(dtG.Columns[2], ListSortDirection.Descending);

        }

        public void UpdtateDatagredViewSearch(string pesQ)
        {
            DateTime oThisDay = DateTime.Now;

            dtG.DataSource = new TiposLogradouros(1, 1, @"", @"", oThisDay, oThisDay, @"").GetDados(@"SELECT * FROM ("
                                               + @"SELECT "
                                               + @"TipoLogradouros_ID AS ID "
                                               + @", TipoLogradouros_CODIGO AS CODIGO "
                                               + @", TipoLogradouros_ABREVIATURA AS ABREVIATURA "
                                               + @", TipoLogradouros_LOGRADOURO AS LOGRADOURO "
                                               + @", CAST(TipoClientes_DtCadastro AS NVARCHAR(20)) AS CADASTRO "
                                               + @", CAST(TipoClientes_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇÃO "
                                               + @"FROM TipoLogradouros "
                                               + @"WHERE (TipoLogradouros_LOGRADOURO LIKE '%" + pesQ + @"%'))");
            dtG.AutoResizeColumns();
            dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtG.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            dtG.Sort(dtG.Columns[4], ListSortDirection.Descending);

        }


        private void TipoLogradouros_Load(object sender, EventArgs e)
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            FrmCidades frm = new FrmCidades();

            frm.ShowIcon = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Size = new Size(700, 438);
            frm.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.MaximizeBox = false;

            //ATUALIZAR DATAGRID VIEW DE CIDADES
            UpdtateDatagredView();
        }

        private void btPesqLogradouro_Click(object sender, EventArgs e)
        {
            UpdtateDatagredViewSearch(txtLogradouro.Text);
        }

        private void tsInserir_Click(object sender, EventArgs e)
        {

        }

        private void dtG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dtG.CurrentRow.Cells[0].Value);
            txtCodigo.Text = Convert.ToString(dtG.CurrentRow.Cells[1].Value);
            txtAbreviature.Text = Convert.ToString(dtG.CurrentRow.Cells[2].Value);
            txtLogradouro.Text = Convert.ToString(dtG.CurrentRow.Cells[3].Value);
        }

        private void ts_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
