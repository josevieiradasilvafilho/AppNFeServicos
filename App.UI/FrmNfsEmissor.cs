using System;
using App.BLL;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;

namespace App.UI
{
    public partial class FrmNfsEmissor : Form
    {
        public FrmNfsEmissor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                              
                DateTime oThisDays = DateTime.Now;
                
                PedidoEnvioLoteRPS oPedidoEnvioLoteRPS = new PedidoEnvioLoteRPS();

                oPedidoEnvioLoteRPS.Cabecalho = new Cabecalho();

                oPedidoEnvioLoteRPS.Cabecalho.CPFCNPJRemetente = new CabecalhoCPFCNPJRemetente();
                oPedidoEnvioLoteRPS.Cabecalho.CPFCNPJRemetente.CNPJ = Convert.ToUInt64(@"23153425000136");//tomador

                oPedidoEnvioLoteRPS.Cabecalho.Versao = 1; //fixo
                oPedidoEnvioLoteRPS.Cabecalho.transacao = false; //fixo
                oPedidoEnvioLoteRPS.Cabecalho.dtInicio = Convert.ToDateTime(oThisDays.ToString("yyyy-MM-dd"));//nf
                oPedidoEnvioLoteRPS.Cabecalho.dtFim = Convert.ToDateTime(oThisDays.ToString("yyyy-MM-dd"));//nf
                oPedidoEnvioLoteRPS.Cabecalho.QtdRPS = 2;//nf
                oPedidoEnvioLoteRPS.Cabecalho.ValorTotalServicos = 2000;//nf
                oPedidoEnvioLoteRPS.Cabecalho.ValorTotalDeducoes = 200;//nf

                oPedidoEnvioLoteRPS.RPS = new RPS();
                oPedidoEnvioLoteRPS.RPS.Assinatura = @" ";

                oPedidoEnvioLoteRPS.RPS.ChaveRPS = new RPSChaveRPS();
                oPedidoEnvioLoteRPS.RPS.ChaveRPS.InscricaoPrestador = 31000000;//tomador
                oPedidoEnvioLoteRPS.RPS.ChaveRPS.SerieRPS = @"LLLLL";
                oPedidoEnvioLoteRPS.RPS.ChaveRPS.NumeroRPS = 1;

                oPedidoEnvioLoteRPS.RPS.TipoRPS = @"RPS-M";//fico
                oPedidoEnvioLoteRPS.RPS.DataEmissao = Convert.ToDateTime(oThisDays.ToString("yyyy-MM-dd"));//nf
                oPedidoEnvioLoteRPS.RPS.StatusRPS = "N";//fixo
                oPedidoEnvioLoteRPS.RPS.TributacaoRPS = "T";//
                oPedidoEnvioLoteRPS.RPS.ValorServicos = 1000;//nf
                oPedidoEnvioLoteRPS.RPS.ValorDeducoes = 100;//nf
                oPedidoEnvioLoteRPS.RPS.CodigoServico = 2658;//nf
                oPedidoEnvioLoteRPS.RPS.AliquotaServicos = Convert.ToDecimal(@"0.05");//nf
                oPedidoEnvioLoteRPS.RPS.ISSRetido = false;//nf


                //Base de Clientes
                oPedidoEnvioLoteRPS.RPS.CPFCNPJTomador = new RPSCPFCNPJTomador();
                oPedidoEnvioLoteRPS.RPS.CPFCNPJTomador.CPF = 21346241830; //cliente
                oPedidoEnvioLoteRPS.RPS.RazaoSocialTomador = @"RODRIGO DA SILVA";//cliente

                oPedidoEnvioLoteRPS.RPS.EnderecoTomador = new RPSEnderecoTomador();
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.TipoLogradouro = @"R";//cliente
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.Logradouro = @"Guararapes";//cliente
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.NumeroEndereco = @"495 A";//cliente
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.ComplementoEndereco = @"ap 102";//cliente
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.Bairro = @"BROOKLIN PAULISTA";//cliente
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.Cidade = 3550308;//cliente
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.UF = @"SP";//cliente
                oPedidoEnvioLoteRPS.RPS.EnderecoTomador.CEP = 4561000;//cliente

                oPedidoEnvioLoteRPS.RPS.EmailTomador = @"rene.maluenda@gmail.com";//cliente
                oPedidoEnvioLoteRPS.RPS.Discriminacao = @"Desenvolvimento de sistema nfs-e";

                XmlSerializer oXmlSerializer = new XmlSerializer(typeof(PedidoEnvioLoteRPS));

                string filename = Environment.CurrentDirectory.Replace(@"\", @"\\")
                                                        + @"\\Arquivos\\Nfs\\"
                                                        + oPedidoEnvioLoteRPS.Cabecalho.CPFCNPJRemetente.CNPJ 
                                                        + DateTime.Now.ToString("yyyyMMddhhmmss") + @".xml";

                TextWriter oWriter = new StreamWriter(filename);

                oXmlSerializer.Serialize(oWriter, oPedidoEnvioLoteRPS);

                var msg = MessageBox.Show("Emitido com sucesso", @"NFs!",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }

            catch (Exception ex)
            {
                var msgErros = MessageBox.Show(ex.Message, @"NFs!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);
            }

        }
    }
}
