using App.Common.Resources;
using App.Common.Validation;
using App.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class TiposLogradouros
    {
        #region PROPRIEDADES

        public int TipoLogradouros_ID { get; set; }
        public int TipoLogradouros_CODIGO { get; set; }
        public string TipoLogradouros_ABREVIATURA { get; set; }
        public string TipoLogradouros_LOGRADOURO { get; set; }
        public DateTime TipoLogradouros_DtAtualizacao { get; set; }
        public DateTime TipoLogradouros_DtCadastro { get; set; }
        public string Scopo { get; set; }

        #endregion

        #region CONSTRUTOR
        public TiposLogradouros(int tipoLogradouros_ID
                                , int tipoLogradouros_CODIGO
                                , string tipoLogradouros_ABREVIATURA
                                , string tipoLogradouros_LOGRADOURO
                                , DateTime tipoLogradouros_DtAtualizacao
                                , DateTime tipoLogradouros_DtCadastro
                        , string scopo
                        )
        {
            this.TipoLogradouros_ID = tipoLogradouros_ID;
            this.TipoLogradouros_CODIGO = tipoLogradouros_CODIGO;
            this.TipoLogradouros_ABREVIATURA = tipoLogradouros_ABREVIATURA;
            this.TipoLogradouros_LOGRADOURO = tipoLogradouros_LOGRADOURO;
            this.TipoLogradouros_DtAtualizacao = tipoLogradouros_DtAtualizacao;
            this.TipoLogradouros_DtCadastro = tipoLogradouros_DtCadastro;
            this.Scopo = scopo;
        }
        #endregion

        #region MÉTODOS
        public void SetDados()
        {
            switch (this.Scopo)
            {
                case @"Delete":

                    Validacoes.CheckArgumentNotEmpty(this.TipoLogradouros_LOGRADOURO, ErrosLista.TipoLogradouros_LOGRADOURO);
                    Validacoes.CheckArgumentNotNull(this.TipoLogradouros_LOGRADOURO, ErrosLista.TipoLogradouros_LOGRADOURO);
                    Validacoes.CheckArgumentLength(this.TipoLogradouros_LOGRADOURO, 5, 50, ErrosLista.TipoLogradouros_LOGRADOURO);
                    break;

                default:

                    Validacoes.CheckArgumentNotEmpty(this.TipoLogradouros_LOGRADOURO, ErrosLista.TipoLogradouros_LOGRADOURO);
                    Validacoes.CheckArgumentNotNull(this.TipoLogradouros_LOGRADOURO, ErrosLista.TipoLogradouros_LOGRADOURO);
                    Validacoes.CheckArgumentLength(this.TipoLogradouros_LOGRADOURO, 5, 50, ErrosLista.TipoLogradouros_LOGRADOURO);

                    Validacoes.CheckArgumentNotEmpty(this.TipoLogradouros_ABREVIATURA, ErrosLista.TipoLogradouros_ABREVIATURA);
                    Validacoes.CheckArgumentNotNull(this.TipoLogradouros_ABREVIATURA, ErrosLista.TipoLogradouros_ABREVIATURA);
                    Validacoes.CheckArgumentLength(this.TipoLogradouros_ABREVIATURA, 5, 50, ErrosLista.TipoLogradouros_ABREVIATURA);

                    Validacoes.CheckArgumentNotNull(this.TipoLogradouros_CODIGO, ErrosLista.TipoLogradouros_CODIGO);

                    break;
            }

        }

        //INSERIR DADOS DA TABELA CIDADES
        public void Inserir()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"INSERT INTO TipoClientes ("
                                                            + @"[TipoLogradouros_CODIGO],[TipoLogradouros_ABREVIATURA],[TipoLogradouros_LOGRADOURO],[TipoClientes_DtCadastro],[TipoClientes_DtAtualizacao]"
                                                            + @") VALUES("
                                                            + @"'" + this.TipoLogradouros_CODIGO + @"',"
                                                            + @"'" + this.TipoLogradouros_ABREVIATURA + @"',"
                                                            + @"'" + this.TipoLogradouros_LOGRADOURO + @"',"
                                                            + @"'" + this.TipoLogradouros_DtCadastro + @"',"
                                                            + @"'" + this.TipoLogradouros_DtAtualizacao + @"')");
        }

        //ATUALIZAR DADOS DA TABELA CIDADES
        public void Atualizar()
        {

            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"UPDATE TipoLogradouro SET "
                                                            + @"TipoLogradouros_CODIGO ='" + this.TipoLogradouros_CODIGO + @"',"
                                                            + @"TipoLogradouros_ABREVIATURA ='" + this.TipoLogradouros_ABREVIATURA + @"',"
                                                            + @"TipoLogradouros_LOGRADOURO ='" + this.TipoLogradouros_LOGRADOURO + @"',"
                                                            + @"TipoClientes_DtAtualizacao = '" + this.TipoLogradouros_DtCadastro + @"'"
                                                            + @" WHERE (TipoLogradouros_Id = '" + this.TipoLogradouros_ID + @"')");

        }

        //REMOVER DADOS DA TABELA CIDADES
        public void Excluir()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"DELETE FROM TipoLogradouro "
                                + @"WHERE (TipoLogradouros_Id = '" + this.TipoLogradouros_ID + @"')");

        }

        public DataTable GetDados(string SQL)
        {
            Banco oBanco = new Banco();
            return oBanco.GetDatatable(SQL);
        }

        #endregion
    }
}
