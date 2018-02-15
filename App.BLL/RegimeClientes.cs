using App.Common.Resources;
using App.Common.Validation;
using App.DAL;
using System;
using System.Data;

namespace App.BLL
{
    public class RegimeClientes
    {

        #region PROPRIEDADES
        public Int32 RegimeClientes_Id { get; set; }
        public string RegimeClientes_Nome { get; set; }
        public Int32 RegimeClientes_Codigo { get; set; }
        public string RegimeClientes_Tributo { get; set; }
        public decimal RegimeClientes_Deducoes { get; set; }
        public DateTime RegimeClientes_DtCadastro { get; set; }
        public DateTime RegimeClientes_DtAtualizacao { get; set; }
        public string Scopo { get; set; }
        #endregion

        #region CONSTRUTOR
        public RegimeClientes(Int32 regimeClientes_Id, string regimeClientes_Nome, Int32 regimeClientes_Codigo, string RegimeClientes_Tributo, decimal regimeClientes_Deducoes, DateTime regimeClientes_DtCadastro, DateTime regimeClientes_DtAtualizacao, string scopo)
        {
            this.RegimeClientes_Id = regimeClientes_Id;
            this.RegimeClientes_Nome = regimeClientes_Nome;
            this.RegimeClientes_Codigo = regimeClientes_Codigo;
            this.RegimeClientes_Tributo = RegimeClientes_Tributo;
            this.RegimeClientes_Deducoes = regimeClientes_Deducoes;
            this.RegimeClientes_DtCadastro = regimeClientes_DtCadastro;
            this.RegimeClientes_DtAtualizacao = regimeClientes_DtAtualizacao;
        }
        #endregion

        #region MÉTODOS

        //VALIDAR CAMPOS
        public void SetDados()
        {
            switch (this.Scopo)
            {
                case @"Delete":

                    Validacoes.CheckArgumentNotEmpty(this.RegimeClientes_Nome, ErrosLista.RegimeClientes_Nome);
                    Validacoes.CheckArgumentNotNull(this.RegimeClientes_Nome, ErrosLista.RegimeClientes_Nome);
                    Validacoes.CheckArgumentLength(this.RegimeClientes_Nome, 5, 50, ErrosLista.RegimeClientes_Nome);

                    break;

                default:

                    Validacoes.CheckArgumentNotEmpty(this.RegimeClientes_Nome, ErrosLista.RegimeClientes_Nome);
                    Validacoes.CheckArgumentNotNull(this.RegimeClientes_Nome, ErrosLista.RegimeClientes_Nome);
                    Validacoes.CheckArgumentLength(this.RegimeClientes_Nome, 2, 50, ErrosLista.RegimeClientes_Nome);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.RegimeClientes_Codigo), ErrosLista.RegimeClientes_Codigo);
                    Validacoes.CheckArgumentNotNull(this.RegimeClientes_Codigo, ErrosLista.RegimeClientes_Codigo);
                    Validacoes.CheckArgumentLength(Convert.ToString(this.RegimeClientes_Codigo), 2, 10, ErrosLista.RegimeClientes_Codigo);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.RegimeClientes_Tributo), ErrosLista.RegimeClientes_Tributo);
                    Validacoes.CheckArgumentNotNull(this.RegimeClientes_Tributo, ErrosLista.RegimeClientes_Tributo);
                    Validacoes.CheckArgumentLength(Convert.ToString(this.RegimeClientes_Tributo), 1 ,1, ErrosLista.RegimeClientes_Tributo);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.RegimeClientes_Deducoes), ErrosLista.RegimeClientes_Deducoes);
                    Validacoes.CheckArgumentNotNull(this.RegimeClientes_Deducoes, ErrosLista.RegimeClientes_Deducoes);
                   
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
            oBanco.ComandoSQL(
                                @"INSERT INTO RegimeClientes ([RegimeClientes_Nome],[RegimeClientes_Codigo],[RegimeClientes_Tributo],[RegimeClientes_DtCadastro],[RegimeClientes_DtAtualizacao]) VALUES("
                                + @"'" + this.RegimeClientes_Nome + @"',"
                                + @"'" + Convert.ToInt32(this.RegimeClientes_Codigo) + @"',"
                                + @"'" + this.RegimeClientes_Tributo + @"',"
                                + @"'" + this.RegimeClientes_DtCadastro + @"',"
                                + @"'" + this.RegimeClientes_DtAtualizacao + @"')");
         }

        //ATUALIZAR DADOS
        public void Atualizar()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"UPDATE RegimeClientes SET "
                                + @"[RegimeClientes_Nome] = '" + this.RegimeClientes_Nome + @"',"
                                + @"[RegimeClientes_Codigo] = '" + this.RegimeClientes_Codigo + @"',"
                                + @"[RegimeClientes_Tributo] = '" + this.RegimeClientes_Tributo + @"',"
                                + @"[RegimeClientes_DtAtualizacao] ='" + this.RegimeClientes_DtAtualizacao + @"'"
                                + @" WHERE (RegimeClientes_Id = '" + this.RegimeClientes_Id + @"')");
        }

        //REMOVER DADOS
        public void Excluir()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(@"DELETE FROM RegimeClientes WHERE (RegimeClientes_Id = '" + this.RegimeClientes_Id + @"')");
        }

        #endregion

    }
}
