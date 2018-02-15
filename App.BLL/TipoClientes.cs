using App.Common.Resources;
using App.Common.Validation;
using App.DAL;
using System;
using System.Data;

namespace App.BLL
{
    public class TipoClientes
    {

        #region PROPRIEDADES

        public int TipoClientes_Id { get; set; }
        public string TipoClientes_Nome { get; set; }
        public DateTime DtAtualizacao { get; set; }
        public DateTime DtCadastro { get; set; }
        public string Scopo { get; set; }

        #endregion

        #region CONSTRUTOR
        public TipoClientes(int tipoClientes_Id
                        , string tipoClientes_Nome
                        , DateTime dtAtualizacao
                        , DateTime dtCadastro
                        , string scopo
                        )
        {
            this.TipoClientes_Id = tipoClientes_Id;
            this.TipoClientes_Nome = tipoClientes_Nome;
            this.DtAtualizacao = dtAtualizacao;
            this.DtCadastro = dtCadastro;
            this.Scopo = scopo;
        }
        #endregion

        #region MÉTODOS

        //VALIDAR CAMPOS
        public void SetDados()
        {
            switch (this.Scopo)
            {
                case @"Delete":
                   
                    Validacoes.CheckArgumentNotEmpty(this.TipoClientes_Nome, ErrosLista.TipoClientes_Nome);
                    Validacoes.CheckArgumentNotNull(this.TipoClientes_Nome, ErrosLista.TipoClientes_Nome);
                    Validacoes.CheckArgumentLength(this.TipoClientes_Nome, 5, 50, ErrosLista.TipoClientes_Nome);
                    break;

                default:

                    Validacoes.CheckArgumentNotEmpty(this.TipoClientes_Nome, ErrosLista.TipoClientes_Nome);
                    Validacoes.CheckArgumentNotNull(this.TipoClientes_Nome, ErrosLista.TipoClientes_Nome);
                    Validacoes.CheckArgumentLength(this.TipoClientes_Nome, 5, 50, ErrosLista.TipoClientes_Nome);
                    break;
            }

        }

        //RETORNAR DADOS
        public DataTable GetDados(string SQL)
        {
            Banco oBanco = new Banco();
            return oBanco.GetDatatable(SQL);
        }

        //INSERIR DADOS DA TABELA CIDADES
        public void Inserir()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"INSERT INTO TipoClientes ([TipoClientes_Nome],[TipoClientes_DtCadastro],[TipoClientes_DtAtualizacao]) VALUES("
                                + @"'" + this.TipoClientes_Nome + @"',"
                                + @"'" + this.DtCadastro + @"',"
                                + @"'" + this.DtAtualizacao + @"')");
        }

        //ATUALIZAR DADOS DA TABELA CIDADES
        public void Atualizar()
        {

            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"UPDATE TipoClientes SET "
                                + @"TipoClientes_Nome ='" + this.TipoClientes_Nome + @"',"
                                + @"TipoClientes_DtAtualizacao = '" + this.DtAtualizacao + @"'"
                                + @" WHERE (TipoClientes_Id = '" + this.TipoClientes_Id + @"')");

        }

        //REMOVER DADOS DA TABELA CIDADES
        public void Excluir()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"DELETE FROM TipoClientes "
                                + @"WHERE (TipoClientes_Nome = '" + this.TipoClientes_Nome + @"')");

        }

        #endregion
    }
}
