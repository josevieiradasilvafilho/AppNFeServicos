using System.Xml.Serialization;

namespace App.BLL
{

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe", IsNullable = true)]
    public partial class PedidoEnvioLoteRPS
    {
        private Cabecalho cabecalhoField;
        private RPS rPSField;
        
        [XmlElementAttribute(Namespace = "")]
        public Cabecalho Cabecalho
        {
            get
            {
                return this.cabecalhoField;
            }
            set
            {
                this.cabecalhoField = value;
            }
        }

       [XmlElementAttribute(Namespace = "")]
        public RPS RPS
        {
            get
            {
                return this.rPSField;
            }
            set
            {
                this.rPSField = value;
            }
        }
    }

    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Cabecalho
    {
        private CabecalhoCPFCNPJRemetente cPFCNPJRemetenteField;
        private bool transacaoField;
        private System.DateTime dtInicioField;
        private System.DateTime dtFimField;
        private byte qtdRPSField;
        private ushort valorTotalServicosField;
        private byte valorTotalDeducoesField;
        private byte versaoField;

        public CabecalhoCPFCNPJRemetente CPFCNPJRemetente
        {
            get
            {
                return this.cPFCNPJRemetenteField;
            }
            set
            {
                this.cPFCNPJRemetenteField = value;
            }
        }
        public bool transacao
        {
            get
            {
                return this.transacaoField;
            }
            set
            {
                this.transacaoField = value;
            }
        }
       
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime dtInicio
        {
            get
            {
                return this.dtInicioField;
            }
            set
            {
                this.dtInicioField = value;
            }
        }
       
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime dtFim
        {
            get
            {
                return this.dtFimField;
            }
            set
            {
                this.dtFimField = value;
            }
        }
        public byte QtdRPS
        {
            get
            {
                return this.qtdRPSField;
            }
            set
            {
                this.qtdRPSField = value;
            }
        }
        public ushort ValorTotalServicos
        {
            get
            {
                return this.valorTotalServicosField;
            }
            set
            {
                this.valorTotalServicosField = value;
            }
        }
        public byte ValorTotalDeducoes
        {
            get
            {
                return this.valorTotalDeducoesField;
            }
            set
            {
                this.valorTotalDeducoesField = value;
            }
        }
       
        [XmlAttributeAttribute()]
        public byte Versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    [XmlTypeAttribute(AnonymousType = true)]
    public partial class CabecalhoCPFCNPJRemetente
    {
        private ulong cNPJField;
        public ulong CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }
    }

    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RPS
    {
        private string assinaturaField;
        private RPSChaveRPS chaveRPSField;
        private string tipoRPSField;
        private System.DateTime dataEmissaoField;
        private string statusRPSField;
        private string tributacaoRPSField;
        private ushort valorServicosField;
        private byte valorDeducoesField;
        private ushort codigoServicoField;
        private decimal aliquotaServicosField;
        private bool iSSRetidoField;
        private RPSCPFCNPJTomador cPFCNPJTomadorField;
        private string razaoSocialTomadorField;
        private RPSEnderecoTomador enderecoTomadorField;
        private string emailTomadorField;
        private string discriminacaoField;
        public string Assinatura
        {
            get
            {
                return this.assinaturaField;
            }
            set
            {
                this.assinaturaField = value;
            }
        }
        public RPSChaveRPS ChaveRPS
        {
            get
            {
                return this.chaveRPSField;
            }
            set
            {
                this.chaveRPSField = value;
            }
        }
        public string TipoRPS
        {
            get
            {
                return this.tipoRPSField;
            }
            set
            {
                this.tipoRPSField = value;
            }
        }
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime DataEmissao
        {
            get
            {
                return this.dataEmissaoField;
            }
            set
            {
                this.dataEmissaoField = value;
            }
        }
        public string StatusRPS
        {
            get
            {
                return this.statusRPSField;
            }
            set
            {
                this.statusRPSField = value;
            }
        }
        public string TributacaoRPS
        {
            get
            {
                return this.tributacaoRPSField;
            }
            set
            {
                this.tributacaoRPSField = value;
            }
        }
        public ushort ValorServicos
        {
            get
            {
                return this.valorServicosField;
            }
            set
            {
                this.valorServicosField = value;
            }
        }
        public byte ValorDeducoes
        {
            get
            {
                return this.valorDeducoesField;
            }
            set
            {
                this.valorDeducoesField = value;
            }
        }
        public ushort CodigoServico
        {
            get
            {
                return this.codigoServicoField;
            }
            set
            {
                this.codigoServicoField = value;
            }
        }
        public decimal AliquotaServicos
        {
            get
            {
                return this.aliquotaServicosField;
            }
            set
            {
                this.aliquotaServicosField = value;
            }
        }
        public bool ISSRetido
        {
            get
            {
                return this.iSSRetidoField;
            }
            set
            {
                this.iSSRetidoField = value;
            }
        }
        public RPSCPFCNPJTomador CPFCNPJTomador
        {
            get
            {
                return this.cPFCNPJTomadorField;
            }
            set
            {
                this.cPFCNPJTomadorField = value;
            }
        }
        public string RazaoSocialTomador
        {
            get
            {
                return this.razaoSocialTomadorField;
            }
            set
            {
                this.razaoSocialTomadorField = value;
            }
        }
        public RPSEnderecoTomador EnderecoTomador
        {
            get
            {
                return this.enderecoTomadorField;
            }
            set
            {
                this.enderecoTomadorField = value;
            }
        }
        public string EmailTomador
        {
            get
            {
                return this.emailTomadorField;
            }
            set
            {
                this.emailTomadorField = value;
            }
        }
        public string Discriminacao
        {
            get
            {
                return this.discriminacaoField;
            }
            set
            {
                this.discriminacaoField = value;
            }
        }
    }

    [XmlTypeAttribute(AnonymousType = true)]
    public partial class RPSChaveRPS
    {
        private uint inscricaoPrestadorField;
        private string serieRPSField;
        private byte numeroRPSField;
        public uint InscricaoPrestador
        {
            get
            {
                return this.inscricaoPrestadorField;
            }
            set
            {
                this.inscricaoPrestadorField = value;
            }
        }
        public string SerieRPS
        {
            get
            {
                return this.serieRPSField;
            }
            set
            {
                this.serieRPSField = value;
            }
        }
        public byte NumeroRPS
        {
            get
            {
                return this.numeroRPSField;
            }
            set
            {
                this.numeroRPSField = value;
            }
        }
        }

    [XmlTypeAttribute(AnonymousType = true)]
    public partial class RPSCPFCNPJTomador
    {
        private ulong cPFField;
        public ulong CPF
        {
            get
            {
                return this.cPFField;
            }
            set
            {
                this.cPFField = value;
            }
        }
    }

    [XmlTypeAttribute(AnonymousType = true)]
    public partial class RPSEnderecoTomador
    {
        private string tipoLogradouroField;
        private string logradouroField;
        private string numeroEnderecoField;
        private string complementoEnderecoField;
        private string bairroField;
        private uint cidadeField;
        private string ufField;
        private uint cEPField;

        public string TipoLogradouro
        {
            get
            {
                return this.tipoLogradouroField;
            }
            set
            {
                this.tipoLogradouroField = value;
            }
        }
        public string Logradouro
        {
            get
            {
                return this.logradouroField;
            }
            set
            {
                this.logradouroField = value;
            }
        }
        public string NumeroEndereco
        {
            get
            {
                return this.numeroEnderecoField;
            }
            set
            {
                this.numeroEnderecoField = value;
            }
        }
        public string ComplementoEndereco
        {
            get
            {
                return this.complementoEnderecoField;
            }
            set
            {
                this.complementoEnderecoField = value;
            }
        }
        public string Bairro
        {
            get
            {
                return this.bairroField;
            }
            set
            {
                this.bairroField = value;
            }
        }
        public uint Cidade
        {
            get
            {
                return this.cidadeField;
            }
            set
            {
                this.cidadeField = value;
            }
        }
        public string UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
        public uint CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }
    }

}
