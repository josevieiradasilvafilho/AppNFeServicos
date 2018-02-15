using System;
using System.IO;


namespace App.BLL
{
    public class Boletos_DadosEmissao
    {


        #region PROPRIEDADES

        //DADOS DO CEDENTE
        public string Cedente_CPForCNPJ { get; set; }
        public string Cedente_Nome { get; set; }
        public string Cedente_Agencia { get; set; }
        public string Cedente_Conta { get; set; }
        public string Cedente_Codigo { get; set; }
        public string Cedente_Numero { get; set; }
        public string Cedente_UF { get; set; }
        public string Cedente_Bairro { get; set; }
        public string Cedente_CEP { get; set; }
        public string Cedente_Cidade { get; set; }
        public string Cedente_Complemento { get; set; }
        public string Cedente_Email { get; set; }
        public string Cedente_End { get; set; }

        //DADOS DO SACADO
        public string Sacado_cpfcnpj { get; set; }
        public string Sacado_nome { get; set; }
        public string Sacado_end { get; set; }
        public string Sacado_bairro { get; set; }
        public string Sacado_cidade { get; set; }
        public string Sacado_cep { get; set; }
        public string Sacado_uf { get; set; }

        //DADOS DO BOLETO BANCÁRIO
        public string Boleto_Carteira { get; set; }
        public decimal Boleto_ValorBoleto { get; set; }
        public string Boleto_NossoNumero { get; set; }
        public DateTime Boleto_Vencimento { get; set; }
        public string Boleto_NumeroDocumento { get; set; }
        public int Boleto_EspecieDocument { get; set; }
        public string Boleto_CodEspecieDocument { get; set; }
        public int Boleto_CodInstrucao { get; set; }
        public string Boleto_DescInstrucao { get; set; }
        public string Boleto_DescInstrucaoLn2 { get; set; }
        public int Boleto_CodigoBanco { get; set; }
        public DateTime Boleto_DataDocumento { get; set; }
        public DateTime Boleto_DataProcessamento { get; set; }
        public int Boleto_PercMulta { get; set; }
        public int Boleto_JurosMora { get; set; }
        public int Boleto_NumArquivoRemessa { get; set; }
        public string Boleto_NumConvenio { get; set; }

        #endregion

        #region CONSTRUTOR

        public Boletos_DadosEmissao
            (
                string sacado_cpfcnpj
                , string sacado_nome
                , string sacado_end
                , string sacado_bairro
                , string sacado_cidade
                , string sacado_cep
                , string sacado_uf

                , string cedente_CPForCNPJ
                , string cedente_Nome
                , string cedente_Agencia
                , string cedente_Conta
                , string cedente_Codigo
                , string cedente_End
                , string cedente_Complemento
                , string cedente_Bairro
                , string cedente_Cidade
                , string cedente_UF
                , string cedente_CEP
                , string cedente_Email

                , string boleto_Carteira
                , decimal boleto_ValorBoleto
                , string boleto_NossoNumero
                , DateTime boleto_Vencimento
                , string boleto_NumeroDocumento
                , int boleto_EspecieDocument
                , string boleto_CodEspecieDocument
                , int boleto_CodInstrucao
                , string boleto_DescInstrucao
                , string boleto_DescInstrucaoLn2
                , int boleto_CodigoBanco
                , DateTime boleto_DataDocumento
                , DateTime boleto_DataProcessamento
                , int boleto_PercMulta
                , int boleto_JurosMora
                , int boleto_NumArquivoRemessa
                , string boleto_NumConvenio


            )
        {
            this.Sacado_cpfcnpj = sacado_cpfcnpj;
            this.Sacado_nome = sacado_nome;
            this.Sacado_end = sacado_end;
            this.Sacado_bairro = sacado_bairro;
            this.Sacado_cidade = sacado_cidade;
            this.Sacado_cep = sacado_cep;
            this.Sacado_uf = sacado_uf;

            this.Cedente_CPForCNPJ = cedente_CPForCNPJ;
            this.Cedente_Nome = cedente_Nome;
            this.Cedente_Agencia = cedente_Agencia;
            this.Cedente_Conta = cedente_Conta;
            this.Cedente_Codigo = cedente_Codigo;
            this.Cedente_End = cedente_End;
            this.Cedente_Complemento = cedente_Complemento;
            this.Cedente_Cidade = cedente_Cidade;
            this.Cedente_Bairro = cedente_Bairro;
            this.Cedente_UF = cedente_UF;
            this.Cedente_CEP = cedente_CEP;
            this.Cedente_Email = cedente_Email;
            this.Boleto_Carteira = boleto_Carteira;
            this.Boleto_ValorBoleto = boleto_ValorBoleto;
            this.Boleto_NossoNumero = boleto_NossoNumero;
            this.Boleto_Vencimento = boleto_Vencimento;
            this.Boleto_NumeroDocumento = boleto_NumeroDocumento;
            this.Boleto_EspecieDocument = boleto_EspecieDocument;
            this.Boleto_CodEspecieDocument = boleto_CodEspecieDocument;
            this.Boleto_CodInstrucao = boleto_CodInstrucao;
            this.Boleto_DescInstrucao = boleto_DescInstrucao;
            this.Boleto_DescInstrucaoLn2 = boleto_DescInstrucaoLn2;
            this.Boleto_CodigoBanco = boleto_CodigoBanco;
            this.Boleto_DataDocumento = boleto_DataDocumento;
            this.Boleto_DataProcessamento = boleto_DataProcessamento;
            this.Boleto_PercMulta = boleto_PercMulta;
            this.Boleto_JurosMora = boleto_JurosMora;
            this.Boleto_NumArquivoRemessa = boleto_NumArquivoRemessa;
            this.Boleto_NumConvenio = boleto_NumConvenio;

        }

        #endregion

        public BoletoNet.Boleto GetBoletos()
        {

            BoletoNet.Boleto oBoleto = new BoletoNet.Boleto(this.Boleto_ValorBoleto, this.Boleto_Carteira, this.Boleto_NossoNumero, new BoletoNet.Cedente(this.Cedente_CPForCNPJ, this.Cedente_Nome, this.Cedente_Agencia, this.Cedente_Conta));

            oBoleto.EspecieDocumento = new BoletoNet.EspecieDocumento(this.Boleto_EspecieDocument, this.Boleto_CodEspecieDocument);
            oBoleto.DataVencimento = this.Boleto_Vencimento;
            oBoleto.Cedente.Codigo = this.Cedente_Codigo;
            oBoleto.NumeroDocumento = this.Boleto_NumeroDocumento;
            oBoleto.DataDocumento = this.Boleto_DataDocumento;
            oBoleto.DataProcessamento = this.Boleto_DataProcessamento;
            oBoleto.PercMulta = this.Boleto_PercMulta;
            oBoleto.JurosMora = this.Boleto_JurosMora;
            oBoleto.Sacado = new BoletoNet.Sacado(this.Sacado_cpfcnpj, this.Sacado_nome);
            oBoleto.Sacado.Endereco.End = this.Sacado_end;
            oBoleto.Sacado.Endereco.Bairro = this.Sacado_bairro;
            oBoleto.Sacado.Endereco.Cidade = this.Sacado_cidade;
            oBoleto.Sacado.Endereco.CEP = this.Sacado_cep;
            oBoleto.Sacado.Endereco.UF = this.Sacado_uf;

            //INSTRUÇÃO LINHA 1
            BoletoNet.Instrucao oInstrucao = new BoletoNet.Instrucao(this.Boleto_CodInstrucao);
            oInstrucao.Descricao = this.Boleto_DescInstrucao;
            oBoleto.Instrucoes.Add(oInstrucao);

            //INSTRUÇÃO LINHA 2
            BoletoNet.Instrucao oInstrucao2 = new BoletoNet.Instrucao(this.Boleto_CodInstrucao);
            oInstrucao2.Descricao = this.Boleto_DescInstrucaoLn2;
            oBoleto.Instrucoes.Add(oInstrucao2);

            //GERA BOLETO BANCÁRIO
            BoletoNet.BoletoBancario oBoletoBancario = new BoletoNet.BoletoBancario();
            oBoletoBancario.CodigoBanco = Convert.ToInt16(this.Boleto_CodigoBanco);
            oBoletoBancario.GerarArquivoRemessa = true;
            oBoletoBancario.MostrarComprovanteEntrega = true;
            oBoletoBancario.Boleto = oBoleto;
            oBoletoBancario.Boleto.Valida();

            //GERAR PDF DO BOLETO
            String sDateTime = Convert.ToString(DateTime.Now).Replace("/", "").Replace(":", "").Trim();
            byte[] file = oBoletoBancario.MontaBytesPDF();
            FileStream oFileStream = new FileStream(@".\Arquivos\Nfs\" + oBoletoBancario.Boleto.NumeroDocumento + @"_" + sDateTime + ".pdf", FileMode.Create);
            oFileStream.Write(file, 0, file.Length);
            oFileStream.Close();

            return oBoleto;
        }

        public BoletoNet.Boleto GetBoletoValidar()
        {

            BoletoNet.Boleto oBoleto = new BoletoNet.Boleto(this.Boleto_ValorBoleto, this.Boleto_Carteira, this.Boleto_NossoNumero, new BoletoNet.Cedente(this.Cedente_CPForCNPJ, this.Cedente_Nome, this.Cedente_Agencia, this.Cedente_Conta));

            oBoleto.EspecieDocumento = new BoletoNet.EspecieDocumento(this.Boleto_EspecieDocument, this.Boleto_CodEspecieDocument);
            oBoleto.DataVencimento = this.Boleto_Vencimento;
            oBoleto.Cedente.Codigo = this.Cedente_Codigo;
            oBoleto.NumeroDocumento = this.Boleto_NumeroDocumento;
            oBoleto.DataDocumento = this.Boleto_DataDocumento;
            oBoleto.DataProcessamento = this.Boleto_DataProcessamento;
            oBoleto.PercMulta = this.Boleto_PercMulta;
            oBoleto.JurosMora = this.Boleto_JurosMora;
            oBoleto.Sacado = new BoletoNet.Sacado(this.Sacado_cpfcnpj, this.Sacado_nome);
            oBoleto.Sacado.Endereco.End = this.Sacado_end;
            oBoleto.Sacado.Endereco.Bairro = this.Sacado_bairro;
            oBoleto.Sacado.Endereco.Cidade = this.Sacado_cidade;
            oBoleto.Sacado.Endereco.CEP = this.Sacado_cep;
            oBoleto.Sacado.Endereco.UF = this.Sacado_uf;

            //INSTRUÇÃO LINHA 1
            BoletoNet.Instrucao oInstrucao = new BoletoNet.Instrucao(this.Boleto_CodInstrucao);
            oInstrucao.Descricao = this.Boleto_DescInstrucao;
            oBoleto.Instrucoes.Add(oInstrucao);

            //INSTRUÇÃO LINHA 2
            BoletoNet.Instrucao oInstrucao2 = new BoletoNet.Instrucao(this.Boleto_CodInstrucao);
            oInstrucao2.Descricao = this.Boleto_DescInstrucaoLn2;
            oBoleto.Instrucoes.Add(oInstrucao2);

            //GERA BOLETO BANCÁRIO
            BoletoNet.BoletoBancario oBoletoBancario = new BoletoNet.BoletoBancario();
            oBoletoBancario.CodigoBanco = Convert.ToInt16(this.Boleto_CodigoBanco);
            oBoletoBancario.GerarArquivoRemessa = true;
            oBoletoBancario.MostrarComprovanteEntrega = true;
            oBoletoBancario.Boleto = oBoleto;
            oBoletoBancario.Boleto.Valida();

            //GERAR PDF DO BOLETO
            String sDateTime = Convert.ToString(DateTime.Now).Replace("/", "").Replace(":", "").Trim();
            byte[] file = oBoletoBancario.MontaBytesPDF();
            FileStream oFileStream = new FileStream(@".\Arquivos\Nfs\" + oBoletoBancario.Boleto.NumeroDocumento + @"_" + sDateTime + ".pdf", FileMode.Create);
            oFileStream.Write(file, 0, file.Length);
            oFileStream.Close();

            return oBoleto;
        }



    }
}
