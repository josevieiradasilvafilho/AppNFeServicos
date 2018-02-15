using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using App.BLL;
using System.ComponentModel;
using System.Text;

namespace App.UI
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        }

        public String ExportarvalortxtClientes_ID
        {
            get { return txtClientes_ID.Text; }
            set { txtClientes_ID.Text = value; }
        }
        public String ExportarvalortxtClientes_Nome
        {
            get { return txtClientes_Nome.Text; }
            set { txtClientes_Nome.Text = value; }
        }
        public String ExportarvalortxtClientes_CNPJorCPF
        {
            get { return txtClientes_CNPJorCPF.Text; }
            set { txtClientes_CNPJorCPF.Text = value; }
        }
        public String ExportarvalortxtClientes_Inscricao
        {
            get { return txtClientes_Inscricao.Text; }
            set { txtClientes_Inscricao.Text = value; }
        }

        public string RemoverAcentos(string texto)
        {
            string s = texto.Normalize(NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            for (int k = 0; k < s.Length; k++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(s[k]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(s[k]);
                }
            }
            return sb.ToString();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.Size = new Size(1072, 531);

            //ATUALIZAR DATAGRID VIEW DE CIDADES
            UpdtateDatagredView();

            txtClientes_CNPJorCPF.Focus();

        }

        private void btnProcurarFrmCidade_Click(object sender, EventArgs e)
        {
            
            FrmCidades oFrmCidades = new FrmCidades();
            
            oFrmCidades.ShowDialog();

            txtCidades_Nome.Text = oFrmCidades.ExportarvalortxtCidade;
            txtCidades_Id.Text = oFrmCidades.ExportarvalortxtId;
            txtCidades_Codigo.Text = oFrmCidades.ExportarvalortxtCodigo;
            txtCidades_UF.Text = oFrmCidades.ExportarvalortxtUF;

        }

        private void btProcurarRegimeClientes_Click(object sender, EventArgs e)
        {
            FrmRegimeClientes oFrmRegimeClientes = new FrmRegimeClientes();

            oFrmRegimeClientes.ShowDialog();

            txtRegimeClientes_Codigo.Text = oFrmRegimeClientes.ExportarvalortxtCodigo;
            txtRegimeClientes_Id.Text = oFrmRegimeClientes.ExportarvalortxtId;
            txtRegimeClientes_Nome.Text = oFrmRegimeClientes.ExportarvalortxtNome;
            txtRegimeClientes_Tributacao.Text = oFrmRegimeClientes.ExportarvalortxtTributo;

        }

        private void btProcurarFrmTipoClientes_Click(object sender, EventArgs e)
        {
            FrmTipoClientes oFrmTipoClientes = new FrmTipoClientes();

            oFrmTipoClientes.ShowDialog();

            txtTipoClientes_Id.Text = oFrmTipoClientes.ExportarvalortxtId;
            txtTipoClientes_Name.Text = oFrmTipoClientes.ExportarvalortxtTipo;
           
        }
                
        public void UpdtateDatagredView()
        {
            DateTime oThisDay = DateTime.Now;
            
            dtG.DataSource = new Clientes(1, @"",1,1, @"", @"", @"", @"", @"", @"", @"", @"", 1, oThisDay, oThisDay, 1, 1,1,@"").GetDados(@"SELECT * FROM ("
                                                + @"SELECT "
                                                + @"Clientes_Id AS ID "
                                                + @", Clientes_Nome AS CLIENTE "
                                                + @", Clientes_TipoPessoa AS TP "
                                                + @", Clientes_CNPJorCPF AS [CNPJ/CPF] "
                                                + @", Clientes_Inscricao AS [I.E.]"
                                                + @", Clientes_TipoLogradouro AS LOGRADOURO "
                                                + @", Clientes_NumLogradouro AS [NÚMERO] "
                                                + @", Clientes_Complemento AS COMPLEMENTO "
                                                + @", Clientes_Bairro AS BAIRRO "
                                                + @", Clientes_Email AS EMAIL "
                                                + @", Clientes_NomeServico AS [SERVIÇO] "
                                                + @", Clientes_Cep AS CEP "
                                                + @", Clientes_TipoClientesId AS TIPOCLIENTES_ID "
                                                + @", TipoClientes_Nome AS [TIPO] "
                                                + @", Clientes_RegimeClientesId AS REGIMECLIENTES_ID "
                                                + @", RegimeClientes_Nome AS [REG.TRIB.] "
                                                + @", RegimeClientes_Codigo AS [COD.REG.TRIB.] "
                                                + @", RegimeClientes_Tributo AS [TRIBUTO] "
                                                + @", Clientes_CidadesId AS CIDADES_ID "
                                                + @", Cidades_Nome AS [CIDADE] "
                                                + @", Cidades_Codigo AS [COD.CIDADE] "
                                                + @", Cidades_UF AS [UF] "
                                                + @", CAST(Clientes_DtCadastro AS NVARCHAR(20)) AS CADASTRO "
                                                + @", CAST(Clientes_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇÃO "
                                                + @" FROM Clientes "
                                                + @" LEFT OUTER JOIN Cidades ON Cidades.Cidades_Id = Clientes.Clientes_CidadesId "
                                                + @" LEFT OUTER JOIN TipoClientes ON TipoClientes.TipoClientes_Id = Clientes.Clientes_TipoClientesId "
                                                + @" LEFT OUTER JOIN RegimeClientes ON RegimeClientes.RegimeClientes_Id = Clientes.Clientes_RegimeClientesId )");


            dtG.AutoResizeColumns();
            dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtG.Columns[23].SortMode = DataGridViewColumnSortMode.Automatic;
            dtG.Sort(dtG.Columns[23], ListSortDirection.Descending);

        }

        public void UpdtateDatagredViewSearch(string parametroClientes, string parametroBusca)
        {
            DateTime oThisDay = DateTime.Now;

            string sParametro = "";


            switch (parametroBusca)
            {
                case @"NOME" :

                    if (String.IsNullOrEmpty(parametroClientes) == false) 
                        sParametro = @" WHERE (UPPER(Clientes_Nome) LIKE '%" + RemoverAcentos(parametroClientes.ToUpper()) + @"%' OR UPPER(Clientes_Nome) LIKE '%" + parametroClientes.ToUpper() + @"%'))";
                    else
                        sParametro = @" WHERE (UPPER(Clientes_Nome) LIKE '%" + RemoverAcentos(parametroClientes.ToUpper()) + @"%'))";
                    break;

                case @"CPForCNPJ":

                    if (String.IsNullOrEmpty(parametroClientes) == false)
                        sParametro = @" WHERE (Clientes_CNPJorCPF LIKE '" + parametroClientes + @"'))";
                    else
                        sParametro = @")";
                    break;

                default:

                    break;
            }

            dtG.DataSource = new Clientes(1, @"", 1, 1, @"", @"", @"", @"", @"", @"", @"", @"", 1, oThisDay, oThisDay, 1, 1, 1, @"").GetDados(@"SELECT * FROM ("
                                         + @"SELECT "
                                                + @"Clientes_Id AS ID "
                                                + @", Clientes_Nome AS CLIENTE "
                                                + @", Clientes_TipoPessoa AS TP "
                                                + @", Clientes_CNPJorCPF AS [CNPJ/CPF] "
                                                + @", Clientes_Inscricao AS [I.E.]"
                                                + @", Clientes_TipoLogradouro AS LOGRADOURO "
                                                + @", Clientes_NumLogradouro AS [NÚMERO] "
                                                + @", Clientes_Complemento AS COMPLEMENTO "
                                                + @", Clientes_Bairro AS BAIRRO "
                                                + @", Clientes_Email AS EMAIL "
                                                + @", Clientes_NomeServico AS [SERVIÇO] "
                                                + @", Clientes_Cep AS CEP "
                                                + @", Clientes_TipoClientesId AS TIPOCLIENTES_ID "
                                                + @", TipoClientes_Nome AS [TIPO] "
                                                + @", Clientes_RegimeClientesId AS REGIMECLIENTES_ID "
                                                + @", RegimeClientes_Nome AS [REG.TRIB.] "
                                                + @", RegimeClientes_Codigo AS [COD.REG.TRIB.] "
                                                + @", RegimeClientes_Tributo AS [TRIBUTO] "
                                                + @", Clientes_CidadesId AS CIDADES_ID "
                                                + @", Cidades_Nome AS [CIDADE] "
                                                + @", Cidades_Codigo AS [COD.CIDADE] "
                                                + @", Cidades_UF AS [UF] "
                                                + @", CAST(Clientes_DtCadastro AS NVARCHAR(20)) AS CADASTRO "
                                                + @", CAST(Clientes_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇÃO "
                                                + @" FROM Clientes "
                                                + @" LEFT OUTER JOIN Cidades ON Cidades.Cidades_Id = Clientes.Clientes_CidadesId "
                                                + @" LEFT OUTER JOIN TipoClientes ON TipoClientes.TipoClientes_Id = Clientes.Clientes_TipoClientesId "
                                                + @" LEFT OUTER JOIN RegimeClientes ON RegimeClientes.RegimeClientes_Id = Clientes.Clientes_RegimeClientesId "
                                                + sParametro);
            dtG.AutoResizeColumns();
            dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtG.Columns[23].SortMode = DataGridViewColumnSortMode.Automatic;
            dtG.Sort(dtG.Columns[23], ListSortDirection.Descending);

        }

        public void AtualizarDados(string Opcao)
        {
            try
            {
            
                DateTime oThisDay = DateTime.Now;

                if (String.IsNullOrEmpty(txtClientes_ID.Text)) txtClientes_ID.Text = @"1";

                string tPpessoa=@"";

                if (chkPessoaFisica.Checked == true)
                {
                    tPpessoa = @"Pessoa Física";
                    txtClientes_Inscricao.Text= @"00000000000000";
                    
                }

                if (chkPessoaJuridica.Checked == true)
                {
                    tPpessoa = @"Pessoa Jurídica";
                    txtClientes_Inscricao.Text = @"";
                   
            }

            //Instanciar dados de inclusão para validação
            var oClientes = new Clientes(
                                        Convert.ToInt32(txtClientes_ID.Text)
                                        , Convert.ToString(txtClientes_Nome.Text)
                                        , Convert.ToInt64(txtClientes_CNPJorCPF.Text)
                                        , Convert.ToInt64(txtClientes_Inscricao.Text)
                                        , Convert.ToString(txtClientes_TipoLogradouro.Text).ToString()
                                        , Convert.ToString(txtClientes_NumLogradouro.Text).ToString()
                                        , Convert.ToString(txtClientes_Complemento.Text).ToString()
                                        , Convert.ToString(txtClientes_Bairro.Text).ToString()
                                        , Convert.ToString(txtClientes_Email.Text).ToString()
                                        , Convert.ToString(txtClientes_Cep.Text).ToString()
                                        , Convert.ToString(txtClientes_NomeServico.Text).ToString()
                                        , Convert.ToString(tPpessoa).ToString()
                                        , Convert.ToDecimal(txtClientes_Valor.Text)
                                        , oThisDay
                                        , oThisDay
                                        , Convert.ToInt32(txtCidades_Id.Text)
                                        , Convert.ToInt32(txtClientes_ID.Text)
                                        , Convert.ToInt32(txtRegimeClientes_Id.Text)
                                        , @"Inserir");

                //VALIDAR DADOS DO USUARIO
                oClientes.SetDados();

                switch (Opcao)
                {
                    case @"Inserir":
                        //INSERIR USUÁRIOS
                        if (MessageBox.Show("Confirma a Inclusão?", @"Usuarios-Erros(Inserir)!",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {

                            oClientes.Inserir();
                            
                            //LIMPAR CAMPOS
                            txtClientes_ID.Clear();
                            txtClientes_Nome.Clear();
                            txtClientes_CNPJorCPF.Clear();
                            txtClientes_Inscricao.Clear();
                            txtClientes_TipoLogradouro.Clear();
                            txtClientes_NumLogradouro.Clear();
                            txtClientes_Complemento.Clear();
                            txtClientes_Bairro.Clear();
                            txtClientes_Cep.Clear();
                            txtClientes_Email.Clear();
                            txtClientes_NomeServico.Clear();
                            tPpessoa = "";
                            txtClientes_Valor.Clear();

                            txtCidades_Id.Clear();
                            txtCidades_Codigo.Clear();
                            txtCidades_Nome.Clear();
                            txtCidades_UF.Clear();

                            txtRegimeClientes_Id.Clear();
                            txtRegimeClientes_Codigo.Clear();
                            txtRegimeClientes_Nome.Clear();
                            txtRegimeClientes_Tributacao.Clear();

                            txtTipoClientes_Id.Clear();
                            txtTipoClientes_Name.Clear();

                            chkPessoaFisica.Checked = false;
                            chkPessoaJuridica.Checked = false;

                        }

                        break;

                    case @"Atualizar":
                        //INSERIR USUÁRIOS
                        if (MessageBox.Show("Confirma a Atualização?", @"Usuarios-Erros(Atualizar)!",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {

                            oClientes.Atualizar();

                            //LIMPAR CAMPOS
                            txtClientes_ID.Clear();
                            txtClientes_Nome.Clear();
                            txtClientes_CNPJorCPF.Clear();
                            txtClientes_Inscricao.Clear();
                            txtClientes_TipoLogradouro.Clear();
                            txtClientes_NumLogradouro.Clear();
                            txtClientes_Complemento.Clear();
                            txtClientes_Bairro.Clear();
                            txtClientes_Email.Clear();
                            txtClientes_Cep.Clear();
                            txtClientes_NomeServico.Clear();
                            tPpessoa = "";
                            txtClientes_Valor.Clear();
                            txtCidades_Id.Clear();
                            txtCidades_Codigo.Clear();
                            txtCidades_Nome.Clear();
                            txtCidades_UF.Clear();
                            txtRegimeClientes_Id.Clear();
                            txtRegimeClientes_Codigo.Clear();
                            txtRegimeClientes_Nome.Clear();
                            txtRegimeClientes_Tributacao.Clear();
                            txtTipoClientes_Id.Clear();
                            txtTipoClientes_Name.Clear();
                            chkPessoaFisica.Checked = false;
                            chkPessoaJuridica.Checked = false;
                        }

                        break;

                    case @"Excluir":
                        //INSERIR USUÁRIOS
                        if (MessageBox.Show("Confirma a Exclusão?", @"Usuarios-Erros(Excluir)!",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            oClientes.Remover();

                            //LIMPAR CAMPOS
                            txtClientes_ID.Clear();
                            txtClientes_Nome.Clear();
                            txtClientes_CNPJorCPF.Clear();
                            txtClientes_Inscricao.Clear();
                            txtClientes_TipoLogradouro.Clear();
                            txtClientes_NumLogradouro.Clear();
                            txtClientes_Complemento.Clear();
                            txtClientes_Bairro.Clear();
                            txtClientes_Email.Clear();
                            txtClientes_Cep.Clear();
                            txtClientes_NomeServico.Clear();
                            tPpessoa = "";
                            txtClientes_Valor.Clear();
                            txtCidades_Id.Clear();
                            txtCidades_Id.Clear();
                            txtRegimeClientes_Id.Clear();
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
                txtClientes_CNPJorCPF.Focus();
            
            }
            catch (Exception ex)

            {

                string sErr = Convert.ToString(ex);
                
                if (sErr.Contains(@"UNIQUE constraint failed"))
                {
                    MessageBox.Show(@"Registro Existente! ", @"Clientes-Erros(Inserção)!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sErr.Contains(@"Input string was not in a correct format."))
                {
                    MessageBox.Show(@"Dados Em Branco! ", @"Clientes-Erros(Inserção)!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, @"Clientes-Erros(Inserção)!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtClientes_CNPJorCPF.Focus();

            }
        }

        public void PulaProxCampoTabIndex(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Inserir");
        }

        private void chkPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPessoaFisica.Checked)
            {
                
                chkPessoaJuridica.Enabled = false;
                txtClientes_Inscricao.Enabled = false;
                txtClientes_Inscricao.Text = @"00000000000000";

            }
            else
            {
                
                chkPessoaJuridica.Enabled = true;
                txtClientes_Inscricao.Enabled = true;
                txtClientes_Inscricao.Text = @"";
            }
            
        }

        private void chkPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {

            if (chkPessoaJuridica.Checked)
            {
                chkPessoaFisica.Enabled = false;
            }
            else
            {
                chkPessoaFisica.Enabled = true;

            }
        }

        private void dtG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtClientes_ID.Text = Convert.ToString(dtG.CurrentRow.Cells[0].Value);

            txtClientes_Nome.Text = Convert.ToString(dtG.CurrentRow.Cells[1].Value);

            if (Convert.ToString(dtG.CurrentRow.Cells[2].Value) == @"Pessoa Física" || Convert.ToString(dtG.CurrentRow.Cells[2].Value) == @"Pessoa Fisica")
            {
                chkPessoaFisica.Checked = true;
            }
            else if(Convert.ToString(dtG.CurrentRow.Cells[2].Value) == @"Pessoa Jurídica" || Convert.ToString(dtG.CurrentRow.Cells[2].Value) == @"Pessoa Juridica")
            {
                chkPessoaJuridica.Checked = true;
                txtClientes_CNPJorCPF.Text = Convert.ToString(dtG.CurrentRow.Cells[4].Value);
            }else
            {
                chkPessoaJuridica.Checked = false;
                chkPessoaFisica.Checked = false;
            }
            
            txtClientes_CNPJorCPF.Text = Convert.ToString(dtG.CurrentRow.Cells[3].Value);
            txtClientes_TipoLogradouro.Text = Convert.ToString(dtG.CurrentRow.Cells[5].Value);
            txtClientes_NumLogradouro.Text = Convert.ToString(dtG.CurrentRow.Cells[6].Value);
            txtClientes_Complemento.Text = Convert.ToString(dtG.CurrentRow.Cells[7].Value);
            txtClientes_Bairro.Text = Convert.ToString(dtG.CurrentRow.Cells[8].Value);
            txtClientes_Email.Text = Convert.ToString(dtG.CurrentRow.Cells[9].Value);
            txtClientes_NomeServico.Text = Convert.ToString(dtG.CurrentRow.Cells[10].Value);
            txtClientes_Cep.Text = Convert.ToString(dtG.CurrentRow.Cells[11].Value);

            txtTipoClientes_Id.Text = Convert.ToString(dtG.CurrentRow.Cells[12].Value);
            txtTipoClientes_Name.Text = Convert.ToString(dtG.CurrentRow.Cells[13].Value);

            txtRegimeClientes_Id.Text = Convert.ToString(dtG.CurrentRow.Cells[14].Value);
            txtRegimeClientes_Nome.Text = Convert.ToString(dtG.CurrentRow.Cells[15].Value);
            txtRegimeClientes_Codigo.Text = Convert.ToString(dtG.CurrentRow.Cells[16].Value);
            txtRegimeClientes_Tributacao.Text = Convert.ToString(dtG.CurrentRow.Cells[17].Value);

            txtCidades_Id.Text = Convert.ToString(dtG.CurrentRow.Cells[18].Value);
            txtCidades_Nome.Text = Convert.ToString(dtG.CurrentRow.Cells[19].Value);
            txtCidades_Codigo.Text = Convert.ToString(dtG.CurrentRow.Cells[20].Value);
            txtCidades_UF.Text = Convert.ToString(dtG.CurrentRow.Cells[21].Value);

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClientes_CNPJorCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClientes_CNPJorCPF_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Atualizar");
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDados(@"Excluir");
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

        private void button1_Click(object sender, EventArgs e)
        {
            UpdtateDatagredViewSearch(txtClientes_CNPJorCPF.Text,"CPForCNPJ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdtateDatagredViewSearch(txtClientes_Nome.Text, "NOME");
        }
    }
}
