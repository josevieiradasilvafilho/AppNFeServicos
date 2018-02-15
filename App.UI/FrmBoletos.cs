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
using System.Globalization;
using System.Threading;
using System.IO;

namespace App.UI
{
    public partial class FrmBoletos : Form
    {
        public FrmBoletos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boletos_DadosEmissao oBoleto = new Boletos_DadosEmissao(
                                                                    @"26797656800"
                                                                    , @"JOSÉ VIEIRA DA SILVA FILHO"
                                                                    , @"RUA MIRASSOL, 89"
                                                                    , @"BOSQUE DOS EUCALIPTOS"
                                                                    , @"SÃO JOSÉ DOS CAMPOS"
                                                                    , @"12233-480"
                                                                    , @"SP"
                                                                    , @"11.457.789/0001-20"
                                                                    , @"SPAZIO CAMPO BIANCO INCORP."
                                                                    , @"2938"
                                                                    , @"09420"
                                                                    , @"1111111"
                                                                    , @"RUA MIRA"
                                                                    , @"CASA 2"
                                                                    , @"BOSQUE"
                                                                    , @"SP"
                                                                    , @"12233-480"
                                                                    , @"jvsilvafilho@josevieiras.com.br"
                                                                    , @"SÃO JOSÉ"
                                                                    , @"109"
                                                                    , Convert.ToDecimal(@"104,51")
                                                                    , @"30007780"
                                                                    , DateTime.Now
                                                                    , @"1800090558"
                                                                    , 341
                                                                    , @"1"
                                                                    , Convert.ToInt16(@"001")
                                                                    , @"ATÉ O VENCIMENTO, PAGUE EM QUALQUER BANCO OU CORRESPONDENTE NÃO BANCÁRIO."
                                                                    , @"APÓS O VENCIMENTO, ACESSE ITAU.COM.BR/BOLETOS E PAGUE EM QUALQUER BANCO OU CORRESPONDENTE NÃO BANCÁRIO."
                                                                    , Convert.ToInt16(@"341")
                                                                    , DateTime.Now
                                                                    , DateTime.Now
                                                                    , Convert.ToInt16(@"10")
                                                                    , Convert.ToInt16(@"5")
                                                                    , Convert.ToInt16(@"0001")
                                                                    , @"09"
                                                                    );
            
            //GERAR REMESSA
            BoletoNet.Boletos oBoletos = new BoletoNet.Boletos();
            oBoletos.Add(oBoleto.GetBoletos());

            //GERAR ARQUIVO DA REMESSA            
            /*
            var oMemoryStream = new MemoryStream();
            var oArquivoRemessa = new BoletoNet.ArquivoRemessa(BoletoNet.TipoArquivo.CNAB400);
            oArquivoRemessa.GerarArquivoRemessa(oBoleto.Boleto_NumConvenio, new BoletoNet.Banco(oBoletoBancario.CodigoBanco), oBoleto.GetBoletos().Cedente, oBoletos, oMemoryStream, oBoleto.Boleto_NumArquivoRemessa);
            File.WriteAllBytes(@".\Arquivos\Remessas\" + oBoletoBancario.Boleto.NumeroDocumento + ".txt", oMemoryStream.ToArray());
            */
            MessageBox.Show(@"Finalizado com Sucesso, Somente o Boleto!", @"Boletos()!", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

                int CodigoBanco = Convert.ToInt16(341);

                //DADOS DO CEDENTE
                Boletos_Cedente oBoletos_Cedente = new Boletos_Cedente();

                oBoletos_Cedente.Nome = "SPAZIO CAMPO BIANCO INCORP.";//
                oBoletos_Cedente.CPForCNPJ = "11.457.789/0001-20";//
                oBoletos_Cedente.Agencia = "2938";//
                oBoletos_Cedente.Conta = "09420";//
                oBoletos_Cedente.Codigo = "1111111";
                oBoletos_Cedente.End = "1111111";
                oBoletos_Cedente.CEP = "12233480";
                oBoletos_Cedente.Complemento = "CONDOMINIO";
                oBoletos_Cedente.UF = "SP";
                oBoletos_Cedente.Email = "spazio@gmail.com";

                //DADOS DO SACADO 
                Boletos_Sacado oBoletos_Sacado = new Boletos_Sacado();
                oBoletos_Sacado.CpforCnpj = "26797656800";//
                oBoletos_Sacado.Nome = "JOSÉ VIEIRA DA SILVA FILHO";//
                oBoletos_Sacado.End = "RUA MIRA89";//
                oBoletos_Sacado.Bairro = "BOSQUES";//
                oBoletos_Sacado.Cidade = "SÃO JOSÉ";//
                oBoletos_Sacado.Cep = "122";//
                oBoletos_Sacado.Uf = "SP";//

                //DADOS DO BOLETO
                Boletos_Boleto oBoletos_Boleto = new Boletos_Boleto();
                oBoletos_Boleto.Carteira = "109";//
                oBoletos_Boleto.ValorBoleto = Convert.ToDecimal("104,51");//
                oBoletos_Boleto.NossoNumero = "30007780";//
                oBoletos_Boleto.Vencimento = Convert.ToDateTime("08/03/2014");//
                oBoletos_Boleto.NumeroDocumento = "1800090558";//
                oBoletos_Boleto.EspecieDocument = 341;
                oBoletos_Boleto.CodEspecieDocument = "1";
                oBoletos_Boleto.CodInstrucao = 001;
                oBoletos_Boleto.DescInstrucao = "ATÉ O VENCIMENTO, PAGUE EM QUALQUER BANCO OU CORRESPONDENTE NÃO BANCÁRIO.";
                oBoletos_Boleto.DescInstrucaoLn2 = @"APÓS O VENCIMENTO, ACESSE ITAU.COM.BR/BOLETOS E PAGUE EM QUALQUER BANCO OU CORRESPONDENTE NÃO BANCÁRIO.";
                oBoletos_Boleto.CodigoBanco = 341;//
                oBoletos_Boleto.DataDocumento = DateTime.Now; ;
                oBoletos_Boleto.DataProcessamento = DateTime.Now;
                oBoletos_Boleto.PercMulta = 10;
                oBoletos_Boleto.JurosMora = 5;
                oBoletos_Boleto.NumArquivoRemessa = 0001;
                oBoletos_Boleto.NumConvenio = "09";

                //BOLETO
                BoletoNet.Boleto oBoleto = new BoletoNet.Boleto(oBoletos_Boleto.ValorBoleto, oBoletos_Boleto.Carteira, oBoletos_Boleto.NossoNumero, new BoletoNet.Cedente(oBoletos_Cedente.CPForCNPJ, oBoletos_Cedente.Nome, oBoletos_Cedente.Agencia, oBoletos_Cedente.Conta));
                oBoleto.EspecieDocumento = new BoletoNet.EspecieDocumento(oBoletos_Boleto.EspecieDocument, oBoletos_Boleto.CodEspecieDocument);
                oBoleto.DataVencimento = oBoletos_Boleto.Vencimento;
                oBoleto.Cedente.Codigo = oBoletos_Cedente.Codigo;
                oBoleto.NumeroDocumento = oBoletos_Boleto.NumeroDocumento;
                oBoleto.DataDocumento = oBoletos_Boleto.DataDocumento;
                oBoleto.DataProcessamento = oBoletos_Boleto.DataProcessamento;
                oBoleto.PercMulta = oBoletos_Boleto.PercMulta;
                oBoleto.JurosMora = oBoletos_Boleto.JurosMora;
                oBoleto.Sacado = new BoletoNet.Sacado(oBoletos_Sacado.CpforCnpj, oBoletos_Sacado.Nome);
                oBoleto.Sacado.Endereco.End = oBoletos_Sacado.End;
                oBoleto.Sacado.Endereco.Bairro = oBoletos_Sacado.Bairro;
                oBoleto.Sacado.Endereco.Cidade = oBoletos_Sacado.Cidade;
                oBoleto.Sacado.Endereco.CEP = oBoletos_Sacado.Cep;
                oBoleto.Sacado.Endereco.UF = oBoletos_Sacado.Uf;

                //INSTRUÇÃO LINHA 1
                BoletoNet.Instrucao oInstrucao = new BoletoNet.Instrucao(oBoletos_Boleto.CodInstrucao);
                oInstrucao.Descricao = oBoletos_Boleto.DescInstrucao;
                oBoleto.Instrucoes.Add(oInstrucao);

                //INSTRUÇÃO LINHA 2
                BoletoNet.Instrucao oInstrucao2 = new BoletoNet.Instrucao(oBoletos_Boleto.CodInstrucao);
                oInstrucao2.Descricao = oBoletos_Boleto.DescInstrucaoLn2;
                oBoleto.Instrucoes.Add(oInstrucao2);

                //GERA BOLETO BANCÁRIO
                BoletoNet.BoletoBancario oBoletoBancario = new BoletoNet.BoletoBancario();
                oBoletoBancario.CodigoBanco = Convert.ToInt16(oBoletos_Boleto.CodigoBanco);
                oBoletoBancario.GerarArquivoRemessa = true;
                oBoletoBancario.MostrarComprovanteEntrega = true;
                oBoletoBancario.Boleto = oBoleto;
                oBoletoBancario.Boleto.Valida();

                //GERAR PDF DO BOLETO
                String sDateTime = Convert.ToString(DateTime.Now).Replace("/", "").Replace(":", "").Trim();
                byte[] file = oBoletoBancario.MontaBytesPDF();
                FileStream oFileStream = new FileStream(@".\Arquivos\Nfs\" + oBoletoBancario.Boleto.NumeroDocumento + @"_" + sDateTime + ".pdf", FileMode.Create);
                oFileStream.Write(file, 0, file.Length);

                //GERAR REMESSA
                BoletoNet.Boletos oBoletos = new BoletoNet.Boletos();
                oBoletos.Add(oBoleto);

                //GERAR ARQUIVO DA REMESSA            
                var oMemoryStream = new MemoryStream();
                var oArquivoRemessa = new BoletoNet.ArquivoRemessa(BoletoNet.TipoArquivo.CNAB400);
                oArquivoRemessa.GerarArquivoRemessa(oBoletos_Boleto.NumConvenio, new BoletoNet.Banco(oBoletoBancario.CodigoBanco), oBoleto.Cedente, oBoletos, oMemoryStream, oBoletos_Boleto.NumArquivoRemessa);
                File.WriteAllBytes(@".\Arquivos\Remessas\" + oBoletoBancario.Boleto.NumeroDocumento + ".txt", oMemoryStream.ToArray());

                //mail.Attachments.Add(new Attachment(@".\" + oBoletoBancario.Boleto.NumeroDocumento + ".pdf"));
                //Thread.CurrentThread.CurrentCulture = originalCulture;


                MessageBox.Show(@"Finalizado com Sucesso!", @"Boletos()!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
