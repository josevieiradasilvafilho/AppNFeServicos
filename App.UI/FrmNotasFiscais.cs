using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using App.BLL;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace App.UI
{
    public partial class FrmNotasFiscais : Form
    {
        public FrmNotasFiscais()
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
            DateTime oThisDay = DateTime.Now;

            dtG.DataSource = new NotasFiscais(1, @"", @"", oThisDay, 1, 1, 1, 1, @"", @"", 1, oThisDay, oThisDay, 1, 1, @"").GetDados(@"SELECT * FROM ("
                                                + @"SELECT "
                                                + @"NotasFiscais_Id AS ID "
                                                + @", NotasFiscais_Numero AS NF "
                                                + @", NotasFiscais_Status AS STATUS "
                                                + @", CAST(NotasFiscais_DataEmissao AS NVARCHAR(20)) AS EMISSÃO"
                                                + @", NotasFiscais_Assinatura AS [ASSINATURA]"
                                                + @", NotasFiscais_Motivo AS MOTIVO "
                                                + @", NotasFiscais_Protocolo AS [PROTOCOLO] "
                                                + @", NotasFiscais_Verificacao AS VERIFICAÇÃO "
                                                + @", NotasFiscais_RPS AS RPS "
                                                + @", NotasFiscais_LOTE AS LOTE "
                                                + @", NotasFiscais_Valor AS [VALOR] "
                                                + @", CAST(NotasFiscais_DtCadastro AS NVARCHAR(20)) AS CADASTRO "
                                                + @", CAST(NotasFiscais_DtAtualizacao AS NVARCHAR(20)) AS ATUALIZAÇÃO "
                                                + @" FROM NotasFiscais "
                                                + @" LEFT OUTER JOIN Clientes ON Clientes.Clientes_Id = NotasFiscais.NotasFiscais_Clientes_Id )");


            dtG.AutoResizeColumns();
            dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtG.Columns[12].SortMode = DataGridViewColumnSortMode.Automatic;
            dtG.Sort(dtG.Columns[12], ListSortDirection.Descending);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string oThisDay = Convert.ToString(DateTime.Now);
                
                PedidoEnvioLoteRPS oPedidoEnvioLoteRPS = new PedidoEnvioLoteRPS();

                oPedidoEnvioLoteRPS.Cabecalho = new Cabecalho();

                oPedidoEnvioLoteRPS.Cabecalho.CPFCNPJRemetente = new CabecalhoCPFCNPJRemetente();
                oPedidoEnvioLoteRPS.Cabecalho.CPFCNPJRemetente.CNPJ = Convert.ToUInt64(@"23153425000136");

                oPedidoEnvioLoteRPS.Cabecalho.Versao = 1; //fixo
                oPedidoEnvioLoteRPS.Cabecalho.transacao = false; //fixo
                oPedidoEnvioLoteRPS.Cabecalho.dtInicio = Convert.ToDateTime(oThisDay);
                oPedidoEnvioLoteRPS.Cabecalho.dtFim = Convert.ToDateTime(oThisDay);
                oPedidoEnvioLoteRPS.Cabecalho.QtdRPS = 2;
                oPedidoEnvioLoteRPS.Cabecalho.ValorTotalServicos = 2000;
                oPedidoEnvioLoteRPS.Cabecalho.ValorTotalDeducoes = 200;

                oPedidoEnvioLoteRPS.RPS = new RPS();
                oPedidoEnvioLoteRPS.RPS.Assinatura = @" ";

                oPedidoEnvioLoteRPS.RPS.ChaveRPS = new RPSChaveRPS();
                oPedidoEnvioLoteRPS.RPS.ChaveRPS.InscricaoPrestador = 31000000;
                oPedidoEnvioLoteRPS.RPS.ChaveRPS.SerieRPS = @"LLLLL";
                oPedidoEnvioLoteRPS.RPS.ChaveRPS.NumeroRPS = 1;

                oPedidoEnvioLoteRPS.RPS.TipoRPS = @"RPS-M";
                oPedidoEnvioLoteRPS.RPS.DataEmissao = Convert.ToDateTime(@"2018-01-28");
                oPedidoEnvioLoteRPS.RPS.StatusRPS = "N";
                oPedidoEnvioLoteRPS.RPS.TributacaoRPS = "T";
                oPedidoEnvioLoteRPS.RPS.ValorServicos = 1000;
                oPedidoEnvioLoteRPS.RPS.ValorDeducoes = 100;
                oPedidoEnvioLoteRPS.RPS.CodigoServico = 2658;
                oPedidoEnvioLoteRPS.RPS.AliquotaServicos = Convert.ToDecimal(@"0.05");
                oPedidoEnvioLoteRPS.RPS.ISSRetido = false;


                //Base de Clientes
                oPedidoEnvioLoteRPS.RPS.CPFCNPJTomador = new RPSCPFCNPJTomador();
                oPedidoEnvioLoteRPS.RPS.CPFCNPJTomador.CPF = 21346241830; //cliente
                oPedidoEnvioLoteRPS.RPS.RazaoSocialTomador = @"RODRIGO DA SILVA";

                oPedidoEnvioLoteRPS.RPS.EnderecoTomador = new RPSEnderecoTomador();
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.TipoLogradouro = @"R";
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.Logradouro = @"Guararapes";
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.NumeroEndereco = @"495 A";
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.ComplementoEndereco = @"ap 102";
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.Bairro = @"BROOKLIN PAULISTA";
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.Cidade = 3550308;
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.UF = @"SP";
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.CEP = 4561000;

                oPedidoEnvioLoteRPS.RPS.EmailTomador = @"rene.maluenda@gmail.com";
                oPedidoEnvioLoteRPS.RPS.Discriminacao = @"Desenvolvimento de sistema nfs-e";

                XmlSerializer oXmlSerializer = new XmlSerializer(typeof(PedidoEnvioLoteRPS));

                string filename = Environment.CurrentDirectory.Replace(@"\", @"\\")
                                                        + @"\\Arquivos\\Nfs\\"
                                                        + oPedidoEnvioLoteRPS.Cabecalho.CPFCNPJRemetente.CNPJ + oThisDay.Replace("/", "").Replace(":", "").Replace(" ", "").Trim() + @".xml";

                TextWriter oWriter = new StreamWriter(filename);

                oXmlSerializer.Serialize(oWriter, oPedidoEnvioLoteRPS);

                var msg = MessageBox.Show("Emitido com sucesso", @"NFs!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);
            }

            catch (Exception ex)
            {
                var msgErros = MessageBox.Show(ex.Message, @"NFs!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);
            }
            finally
            {
                //Exclui o obj email da memória
                //oMailMessage.Dispose();
            }
            
        }

        private void FrmNfs_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;

            //ATUALIZAR DATAGRID VIEW DE CIDADES
            UpdtateDatagredView();

            btProcurarCliente.Focus();
        }

        private void ts_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmClientes oFrmCidades = new FrmClientes();

            oFrmCidades.ShowDialog();

            txtClientes_Id.Text = oFrmCidades.ExportarvalortxtClientes_ID;
            txtClientes_Nome.Text = oFrmCidades.ExportarvalortxtClientes_Nome;
            txtClientes_CNPJorCPF.Text = oFrmCidades.ExportarvalortxtClientes_CNPJorCPF;
            txtClientes_Inscricao.Text = oFrmCidades.ExportarvalortxtClientes_Inscricao;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tsInserir_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
