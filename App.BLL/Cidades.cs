using System;
using App.Common.Validation;
using App.Common.Resources;
using App.DAL;
using System.Data;

namespace App.BLL
{
    public class Cidades
    {

        #region PROPRIEDADES

        public int Cidades_Id { get; set; }
        public string Cidades_Codigo { get; set; }
        public string Cidades_Nome { get; set; }
        public string Cidades_UF { get; set; }
        public DateTime DtAtualizacao { get; set; }
        public DateTime DtCadastro { get; set; }
        public string Scopo { get; set; }

        #endregion

        #region CONSTRUTOR
        public Cidades(int cidades_Id
                        , string cidades_Nome
                        , string cidades_Codigo
                        , string cidades_UF
                        , DateTime dtAtualizacao
                        , DateTime dtCadastro
                        , string scopo
                        )
        {
            this.Cidades_Id = cidades_Id;
            this.Cidades_Nome = cidades_Nome;
            this.Cidades_Codigo = cidades_Codigo;
            this.Cidades_UF = cidades_UF;
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
                case @"Excluir":
                   
                    Validacoes.CheckArgumentNotEmpty(this.Cidades_Nome, ErrosLista.Cidades_Nome);
                    Validacoes.CheckArgumentNotNull(this.Cidades_Nome, ErrosLista.Cidades_Nome);
                    Validacoes.CheckArgumentLength(this.Cidades_Nome, 5, 50, ErrosLista.Cidades_Nome);
                    break;
                default:
                    //VALIDAR CIDADES
                   
                    Validacoes.CheckArgumentNotEmpty(this.Cidades_Nome, ErrosLista.Cidades_Nome);
                    Validacoes.CheckArgumentNotNull(this.Cidades_Nome, ErrosLista.Cidades_Nome);
                    Validacoes.CheckArgumentLength(this.Cidades_Nome, 5, 50, ErrosLista.Cidades_Nome);
                                        
                    Validacoes.CheckArgumentNotEmpty(this.Cidades_Codigo, ErrosLista.Cidades_Codigo);
                    Validacoes.CheckArgumentNotNull(this.Cidades_Codigo, ErrosLista.Cidades_Codigo);
                    Validacoes.CheckArgumentLength(this.Cidades_Codigo, 2, 10, ErrosLista.Cidades_Codigo);

                    Validacoes.CheckArgumentNotEmpty(this.Cidades_UF, ErrosLista.Cidades_UF);
                    Validacoes.CheckArgumentNotNull(this.Cidades_UF, ErrosLista.Cidades_UF);
                    Validacoes.CheckArgumentLength(this.Cidades_UF, 2, 2, ErrosLista.Cidades_UF);

                    break;
            }
            
        }

        //RETORNAR DADOS DA TABELA CIDADES
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
                                @"INSERT INTO CIDADES ([Cidades_Nome],[Cidades_Codigo],[Cidades_UF],[Cidades_DtCadastro],[Cidades_DtAtualizacao]) VALUES("
                                + @"'" + this.Cidades_Nome + @"',"
                                + @"'" + this.Cidades_Codigo + @"',"
                                + @"'" + this.Cidades_UF + @"',"
                                + @"'" + this.DtCadastro + @"',"
                                + @"'" + this.DtAtualizacao + @"')");
        }

        //ATUALIZAR DADOS DA TABELA CIDADES
        public void Atualizar()
        {

            Banco oBanco = new Banco();
            
            oBanco.ComandoSQL(
                                @"UPDATE CIDADES SET "
                                + @"Cidades_Nome ='" + this.Cidades_Nome + @"',"
                                + @"Cidades_Codigo ='" + this.Cidades_Codigo + @"',"
                                + @"Cidades_UF ='" + this.Cidades_UF + @"',"
                                + @"Cidades_DtAtualizacao = '" + this.DtAtualizacao + @"'"
                                + @" WHERE (Cidades_Id = '" + this.Cidades_Id + @"')");

        }

        //REMOVER DADOS DA TABELA CIDADES
        public void Remover()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"DELETE FROM CIDADES "
                                + @"WHERE (Cidades_Id = '" + this.Cidades_Id + @"')");

        }
        
        #endregion

    }
}
