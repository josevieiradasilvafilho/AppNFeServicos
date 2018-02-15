using App.Common.Resources;
using App.Common.Validation;
using App.DAL;
using System;
using System.Data;

namespace App.BLL
{
    public class Clientes
    {

        #region PROPRIEDADES
        public int Clientes_Id { get; set; }
        public string Clientes_Nome { get; set; }
        public Int64 Clientes_CNPJorCPF { get; set; }
        public Int64 Clientes_Inscricao { get; set; }
        public string Clientes_TipoLogradouro { get; set; }
        public string Clientes_NumLogradouro { get; set; }
        public string Clientes_Complemento { get; set; }
        public string Clientes_Bairro { get; set; }
        public string Clientes_Email { get; set; }
        public string Clientes_Cep { get; set; }
        public string Clientes_NomeServico { get; set; }
        public string Clientes_TipoPessoa { get; set; }
        public decimal Clientes_Valor { get; set; }
        public DateTime Clientes_DtCadastro { get; set; }
        public DateTime Clientes_DtAtualizacao { get; set; }
        public string Scopo { get; set; }
        //Chave Estrangeira
        public int Cidades_Id { get; set; }
        public int TipoClientes_Id { get; set; }
        public int RegimeClientes_Id { get; set; }
        
        #endregion

        #region CONSTRUTOR
        public Clientes(int clientes_Id
                        , string clientes_Nome
                        , Int64 clientes_CNPJorCPF
                        , Int64 clientes_Inscricao
                        , string clientes_TipoLogradouro
                        , string clientes_NumLogradouro
                        , string clientes_Complemento
                        , string clientes_Bairro
                        , string clientes_Email
                        , string clientes_Cep
                        , string clientes_NomeServico
                        , string Clientes_TipoPessoa
                        , decimal clientes_Valor
                        , DateTime clientes_DtCadastro
                        , DateTime clientes_DtAtualizacao
                        , int cidades_Id
                        , int tipoClientes_Id
                        , int regimeClientes_Id
                        , string scopo)
        {

            
            this.Clientes_Id = clientes_Id;
            this.Clientes_Nome = clientes_Nome;
            this.Clientes_CNPJorCPF = clientes_CNPJorCPF;
            this.Clientes_Inscricao = clientes_Inscricao;
            this.Clientes_TipoLogradouro = clientes_TipoLogradouro;
            this.Clientes_NumLogradouro = clientes_NumLogradouro;
            this.Clientes_Complemento = clientes_Complemento;
            this.Clientes_Bairro = clientes_Bairro;
            this.Clientes_Email = clientes_Email;
            this.Clientes_Cep = clientes_Cep;
            this.Clientes_NomeServico = clientes_NomeServico;
            this.Clientes_TipoPessoa = Clientes_TipoPessoa;
            this.Clientes_Valor = clientes_Valor;
            this.Clientes_DtCadastro = clientes_DtCadastro;
            this.Clientes_DtAtualizacao = clientes_DtAtualizacao;
            this.Scopo = scopo;
            //chave estrangeira
            this.Cidades_Id = cidades_Id;
            this.TipoClientes_Id = tipoClientes_Id;
            this.RegimeClientes_Id = regimeClientes_Id;

        }
        #endregion

        #region MÉTODOS

        //VALIDADANDO DADOS 
        public void SetDados()
        {
            switch (this.Scopo)
            {
                case @"Delete":

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.Clientes_CNPJorCPF), ErrosLista.Clientes_CNPJorCPF);
                    Validacoes.CheckArgumentNotNull(this.Clientes_CNPJorCPF, ErrosLista.Clientes_CNPJorCPF);
                    Validacoes.CheckArgumentLength(Convert.ToString(this.Clientes_CNPJorCPF), 5, 50, ErrosLista.Clientes_CNPJorCPF);

                    break;

                default:

                    Validacoes.CheckArgumentNotEmpty(this.Clientes_Nome, ErrosLista.Clientes_Nome);
                    Validacoes.CheckArgumentNotNull(this.Clientes_Nome, ErrosLista.Clientes_Nome);
                    Validacoes.CheckArgumentLength(this.Clientes_Nome, 5, 50, ErrosLista.Clientes_Nome);
                     
                    switch (this.Clientes_TipoPessoa)
                    {

                        case @"Pessoa Jurídica":

                            Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.Clientes_CNPJorCPF), ErrosLista.Clientes_CNPJorCPF);
                            Validacoes.CheckArgumentNotNull(this.Clientes_CNPJorCPF, ErrosLista.Clientes_CNPJorCPF);
                            Validacoes.CheckArgumentCnpj(Convert.ToString(this.Clientes_CNPJorCPF), ErrosLista.Clientes_CNPJorCPF);
                            Validacoes.CheckArgumentLength(Convert.ToString(this.Clientes_CNPJorCPF), 5, 14, ErrosLista.Clientes_CNPJorCPF);

                            Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.Clientes_Inscricao), ErrosLista.Clientes_Inscricao);
                            Validacoes.CheckArgumentNotNull(this.Clientes_Inscricao, ErrosLista.Clientes_Inscricao);
                            Validacoes.CheckArgumentLength(Convert.ToString(this.Clientes_Inscricao), 14, 14, ErrosLista.Clientes_Inscricao);

                            break;

                        case @"Pessoa Física":
                            Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.Clientes_CNPJorCPF), ErrosLista.Clientes_CNPJorCPF);
                            Validacoes.CheckArgumentNotNull(this.Clientes_CNPJorCPF, ErrosLista.Clientes_CNPJorCPF);
                            Validacoes.CheckArgumentCpf(Convert.ToString(this.Clientes_CNPJorCPF), ErrosLista.Clientes_CPF);
                            Validacoes.CheckArgumentLength(Convert.ToString(this.Clientes_CNPJorCPF), 5, 14, ErrosLista.Clientes_CPF);
                            break;

                        default:
                            break;
                    }

                    
                    
                    Validacoes.CheckArgumentNotEmpty(this.Clientes_TipoLogradouro, ErrosLista.Clientes_TipoLogradouro);
                    Validacoes.CheckArgumentNotNull(this.Clientes_TipoLogradouro, ErrosLista.Clientes_TipoLogradouro);
                    Validacoes.CheckArgumentLength(this.Clientes_TipoLogradouro, 3, 50, ErrosLista.Clientes_TipoLogradouro);
                  
                    Validacoes.CheckArgumentNotEmpty(this.Clientes_NumLogradouro, ErrosLista.Clientes_NumLogradouro);
                    Validacoes.CheckArgumentNotNull(this.Clientes_NumLogradouro, ErrosLista.Clientes_NumLogradouro);
                    Validacoes.CheckArgumentLength(this.Clientes_NumLogradouro, 1, 50, ErrosLista.Clientes_NumLogradouro);

                    Validacoes.CheckArgumentNotEmpty(this.Clientes_Complemento, ErrosLista.Clientes_Complemento);
                    Validacoes.CheckArgumentNotNull(this.Clientes_Complemento, ErrosLista.Clientes_Complemento);
                    Validacoes.CheckArgumentLength(this.Clientes_Complemento, 5, 50, ErrosLista.Clientes_Complemento);

                    Validacoes.CheckArgumentNotEmpty(this.Clientes_Bairro, ErrosLista.Clientes_Bairro);
                    Validacoes.CheckArgumentNotNull(this.Clientes_Bairro, ErrosLista.Clientes_Bairro);
                    Validacoes.CheckArgumentLength(this.Clientes_Bairro, 5, 50, ErrosLista.Clientes_Bairro);

                    Validacoes.CheckArgumentNotEmpty(this.Clientes_Email, ErrosLista.Email_Invalido);
                    Validacoes.CheckArgumentNotNull(this.Clientes_Email, ErrosLista.Email_Invalido);
                    Validacoes.CheckArgumentEmail(this.Clientes_Email, ErrosLista.Email_Invalido);
                    Validacoes.CheckArgumentLength(this.Clientes_Email, 5, 50, ErrosLista.Email_Invalido);

                    Validacoes.CheckArgumentNotEmpty(this.Clientes_Cep, ErrosLista.Clientes_Cep);
                    Validacoes.CheckArgumentNotNull(this.Clientes_Cep, ErrosLista.Clientes_Cep);
                    Validacoes.CheckArgumentLength(this.Clientes_Cep, 1, 10, ErrosLista.Clientes_Cep);

                    Validacoes.CheckArgumentNotEmpty(this.Clientes_NomeServico, ErrosLista.Clientes_NomeServico);
                    Validacoes.CheckArgumentNotNull(this.Clientes_NomeServico, ErrosLista.Clientes_NomeServico);
                    Validacoes.CheckArgumentLength(this.Clientes_NomeServico, 5, 50, ErrosLista.Clientes_NomeServico);

                    Validacoes.CheckArgumentNotEmpty(this.Clientes_TipoPessoa, ErrosLista.Clientes_TipoPessoa);
                    Validacoes.CheckArgumentNotNull(this.Clientes_TipoPessoa, ErrosLista.Clientes_TipoPessoa);
                    Validacoes.CheckArgumentLength(this.Clientes_TipoPessoa, 5, 50, ErrosLista.Clientes_TipoPessoa);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.Clientes_Valor), ErrosLista.Clientes_Valor);
                    Validacoes.CheckArgumentNotNull(this.Clientes_Valor, ErrosLista.Clientes_Valor);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.Cidades_Id), ErrosLista.Cidades_Nome);
                    Validacoes.CheckArgumentNotNull(this.Cidades_Id, ErrosLista.Cidades_Nome);
                    
                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.TipoClientes_Id), ErrosLista.TipoClientes_Nome);
                    Validacoes.CheckArgumentNotNull(this.TipoClientes_Id, ErrosLista.TipoClientes_Nome);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.RegimeClientes_Id), ErrosLista.RegimeClientes_Nome);
                    Validacoes.CheckArgumentNotNull(this.RegimeClientes_Id, ErrosLista.RegimeClientes_Nome);

                    break;
            }
        }

        //RETORNAR DADOS PARA O DATAGREDVIEW
        public DataTable GetDados(string SQL)
        {
            Banco oBanco = new Banco();
            return oBanco.GetDatatable(SQL);
        }

        //INSERIR DADOS
        public void Inserir()
        {
            Banco oBanco = new Banco();

            oBanco.ComandoSQL(@"INSERT INTO Clientes ("
                                                + @"[Clientes_Nome]"
                                                + @",[Clientes_CNPJorCPF]"
                                                + @",[Clientes_Inscricao]"
                                                + @",[Clientes_TipoLogradouro]"
                                                + @",[Clientes_NumLogradouro]"
                                                + @",[Clientes_Complemento]"
                                                + @",[Clientes_Bairro]"
                                                + @",[Clientes_Email]"
                                                + @",[Clientes_Cep]"
                                                + @",[Clientes_NomeServico]"
                                                + @",[Clientes_TipoPessoa]"
                                                + @",[Clientes_Valor]"
                                                + @",[Clientes_DtCadastro]"
                                                + @",[Clientes_DtAtualizacao]"
                                                + @",[Clientes_CidadesId]"
                                                + @",[Clientes_RegimeClientesId]"
                                                + @",[Clientes_TipoClientesId]) VALUES("
                                                + @"'" + this.Clientes_Nome + @"',"
                                                + @"'" + this.Clientes_CNPJorCPF + @"',"
                                                + @"'" + this.Clientes_Inscricao + @"',"
                                                + @"'" + this.Clientes_TipoLogradouro + @"',"
                                                + @"'" + this.Clientes_NumLogradouro + @"',"
                                                + @"'" + this.Clientes_Complemento + @"',"
                                                + @"'" + this.Clientes_Bairro + @"',"
                                                + @"'" + this.Clientes_Email + @"',"
                                                + @"'" + this.Clientes_Cep + @"',"
                                                + @"'" + this.Clientes_NomeServico + @"',"
                                                + @"'" + this.Clientes_TipoPessoa + @"',"
                                                + @"'" + this.Clientes_Valor + @"',"
                                                + @"'" + this.Clientes_DtCadastro + @"',"
                                                + @"'" + this.Clientes_DtAtualizacao + @"',"
                                                + @"'" + this.Cidades_Id + @"',"
                                                + @"'" + this.RegimeClientes_Id + @"',"
                                                + @"'" + this.TipoClientes_Id + @"')");
        }

        //ATUALIZAR DADOS
        public void Atualizar()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                            @"UPDATE Clientes SET [Clientes_Nome] = " + @"'" + this.Clientes_Nome + @"', "
                                                + @"[Clientes_CNPJorCPF] = "+ @"'" + this.Clientes_CNPJorCPF + @"', "
                                                + @"[Clientes_Inscricao] = " + @"'" + this.Clientes_Inscricao + @"', "
                                                + @"[Clientes_TipoLogradouro] = " + @"'" + this.Clientes_TipoLogradouro + @"', "
                                                + @"[Clientes_NumLogradouro] = " + @"'" + this.Clientes_NumLogradouro + @"', "
                                                + @"[Clientes_Complemento] = " + @"'" + this.Clientes_Complemento + @"', "
                                                + @"[Clientes_Bairro] = " + @"'" + this.Clientes_Bairro + @"', "
                                                + @"[Clientes_Email] = " + @"'" + this.Clientes_Email + @"', "
                                                + @"[Clientes_Cep] = " + @"'" + this.Clientes_Cep + @"', "
                                                + @"[Clientes_NomeServico] = " + @"'" + this.Clientes_NomeServico + @"', "
                                                + @"[Clientes_TipoPessoa] = " + @"'" + this.Clientes_TipoPessoa + @"', "
                                                + @"[Clientes_Valor] = " + @"'" + this.Clientes_Valor + @"', "
                                                + @"[Clientes_DtCadastro] = " + @"'" + this.Clientes_DtCadastro + @"', "
                                                + @"[Clientes_DtAtualizacao] = " + @"'" + this.Clientes_DtAtualizacao + @"', "
                                                + @"[Clientes_CidadesId] = " + @"'" + this.Cidades_Id + @"', "
                                                + @"[Clientes_RegimeClientesId] = " + @"'" + this.RegimeClientes_Id + @"', "
                                                + @"[Clientes_TipoClientesId] = " + @"'" + this.TipoClientes_Id + @"' "
                                                + @"WHERE (Clientes_Id = '" + this.Clientes_Id + @"')");
           
        }

        //REMOVER DADOS
        public void Remover()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"DELETE FROM Clientes "
                                + @"WHERE (Clientes_Id = '" + this.Clientes_Id + @"')");

        }

        #endregion

    }

}
