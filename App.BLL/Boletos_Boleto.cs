using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class Boletos_Boleto
    {

        public string Carteira { get; set; }
        public decimal ValorBoleto { get; set; }
        public string NossoNumero { get; set; }
        public DateTime Vencimento { get; set; }
        public string NumeroDocumento { get; set; }
        public int EspecieDocument { get; set; }
        public string CodEspecieDocument { get; set; }
        public int CodInstrucao { get; set; }
        public string DescInstrucao { get; set; }
        public string DescInstrucaoLn2 { get; set; }        
        public int CodigoBanco { get; set; }
        public DateTime DataDocumento { get; set; }
        public DateTime DataProcessamento { get; set; }
        public int PercMulta { get; set; }
        public int JurosMora { get; set; }
        public int NumArquivoRemessa { get; set; }
        public string NumConvenio { get; set; }

    }
}
