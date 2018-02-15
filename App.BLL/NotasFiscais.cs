using System;
using App.Common.Validation;
using App.Common.Resources;
using System.Data;
using App.DAL;

namespace App.BLL
{
    public class NotasFiscais
    {

        #region PROPRIEDADES
        public Int64 NotasFiscais_Id { get; set; }
        public string NotasFiscais_Numero { get; private set; }
        public string NotasFiscais_Status { get; private set; }
        public DateTime NotasFiscais_DataEmissao { get; private set; }
        public Int64 NotasFiscais_Assinatura { get; private set; }
        public Int64 NotasFiscais_Motivo { get; private set; }
        public Int64 NotasFiscais_Protocolo { get; private set; }
        public Int64 NotasFiscais_Verificacao { get; private set; }
        public string NotasFiscais_RPS { get; private set; }
        public string NotasFiscais_Lote { get; private set; }
        public decimal NotasFiscais_Valor { get; set; }
        public DateTime NotasFiscais_DtAtualizacao { get; set; }
        public DateTime NotasFiscais_DtCadastro { get; set; }
        public Int64 NotasFiscais_Clientes_Id { get; set; }
        public Int64 NotasFiscais_Clientes_Id_Tomador { get; set; }
        public string Scopo { get; set; }
        #endregion

        #region CONSTRUTOR

        public NotasFiscais(int NotasFiscais_Id
                            , string notasFiscais_Numero
                            , string notasFiscais_Status
                            , DateTime notasFiscais_DataEmissao           
                            , Int32 notasFiscais_Assinatura
                            , Int32 notasFiscais_Motivo
                            , Int32 notasFiscais_Protocolo
                            , Int32 notasFiscais_Verificacao
                            , string notasFiscais_RPS
                            , string notasFiscais_Lote
                            , decimal notasFiscais_Valor
                            , DateTime notasFiscais_DtAtualizacao
                            , DateTime notasFiscais_DtCadastro
                            , Int32 notasFiscais_Clientes_Id
                            , Int32 notasFiscais_Clientes_Id_Tomador
                            , string scopo
                            )
        {
            this.NotasFiscais_Id  = notasFiscais_Clientes_Id;
            this.NotasFiscais_Numero = notasFiscais_Numero;
            this.NotasFiscais_Status = notasFiscais_Status;
            this.NotasFiscais_DataEmissao = notasFiscais_DataEmissao;
            this.NotasFiscais_Assinatura = notasFiscais_Assinatura;
            this.NotasFiscais_Motivo = notasFiscais_Motivo;
            this.NotasFiscais_Protocolo = notasFiscais_Protocolo;
            this.NotasFiscais_Verificacao = notasFiscais_Verificacao;
            this.NotasFiscais_RPS = notasFiscais_RPS;
            this.NotasFiscais_Lote = notasFiscais_Lote;
            this.NotasFiscais_Valor = notasFiscais_Valor;
            this.NotasFiscais_DtAtualizacao = notasFiscais_DtAtualizacao;
            this.NotasFiscais_DtCadastro = notasFiscais_DtCadastro;
            this.NotasFiscais_Clientes_Id = notasFiscais_Clientes_Id;
            this.NotasFiscais_Clientes_Id_Tomador = notasFiscais_Clientes_Id_Tomador;
            this.Scopo = scopo;
        }

        #endregion

        #region MÉTODOS

        //VALIDADANDO DADOS 
        public void SetDados()
        {
            switch (this.Scopo)
            {
                case @"Delete":

                    Validacoes.CheckArgumentLength(this.NotasFiscais_Numero, 5, 50, ErrosLista.NotasFiscais_Numero);
                    Validacoes.CheckArgumentNotEmpty(this.NotasFiscais_Numero, ErrosLista.NotasFiscais_Numero);
                    Validacoes.CheckArgumentNotNull(this.NotasFiscais_Numero, ErrosLista.NotasFiscais_Numero);

                    break;

                default:
                    //VALIDAR NUMERO DA NOTA FISCAL
                    Validacoes.CheckArgumentNotEmpty(this.NotasFiscais_Numero, ErrosLista.NotasFiscais_Numero);
                    Validacoes.CheckArgumentNotNull(this.NotasFiscais_Numero, ErrosLista.NotasFiscais_Numero);
                    Validacoes.CheckArgumentLength(this.NotasFiscais_Numero, 2, 20, ErrosLista.NotasFiscais_Numero);

                    //
                    Validacoes.CheckArgumentNotEmpty(this.NotasFiscais_Status, ErrosLista.NotasFiscais_Status);
                    Validacoes.CheckArgumentNotNull(this.NotasFiscais_Status, ErrosLista.NotasFiscais_Status);
                    Validacoes.CheckArgumentLength(this.NotasFiscais_Status, 1, 1, ErrosLista.NotasFiscais_Status);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.NotasFiscais_DataEmissao), ErrosLista.NotasFiscais_DataEmissao);
                    Validacoes.CheckArgumentNotNull(Convert.ToString(this.NotasFiscais_DataEmissao), ErrosLista.NotasFiscais_DataEmissao);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.NotasFiscais_Assinatura), ErrosLista.NotasFiscais_Assinatura);
                    Validacoes.CheckArgumentNotNull(Convert.ToString(this.NotasFiscais_Assinatura), ErrosLista.NotasFiscais_Assinatura);
                    Validacoes.CheckArgumentLength(Convert.ToString(this.NotasFiscais_Assinatura), 1, 87, ErrosLista.NotasFiscais_Assinatura);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.NotasFiscais_Motivo), ErrosLista.NotasFiscais_Motivo);
                    Validacoes.CheckArgumentNotNull(Convert.ToString(this.NotasFiscais_Motivo), ErrosLista.NotasFiscais_Motivo);
                    Validacoes.CheckArgumentLength(Convert.ToString(this.NotasFiscais_Motivo), 1, 87, ErrosLista.NotasFiscais_Motivo);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.NotasFiscais_Protocolo), ErrosLista.NotasFiscais_Protocolo);
                    Validacoes.CheckArgumentNotNull(Convert.ToString(this.NotasFiscais_Protocolo), ErrosLista.NotasFiscais_Protocolo);
                    Validacoes.CheckArgumentLength(Convert.ToString(this.NotasFiscais_Protocolo), 1, 87, ErrosLista.NotasFiscais_Protocolo);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.NotasFiscais_Verificacao), ErrosLista.NotasFiscais_Verificacao);
                    Validacoes.CheckArgumentNotNull(Convert.ToString(this.NotasFiscais_Verificacao), ErrosLista.NotasFiscais_Verificacao);
                    Validacoes.CheckArgumentLength(Convert.ToString(this.NotasFiscais_Verificacao), 1, 87, ErrosLista.NotasFiscais_Verificacao);

                    Validacoes.CheckArgumentNotEmpty(this.NotasFiscais_RPS, ErrosLista.NotasFiscais_RPS);
                    Validacoes.CheckArgumentNotNull(this.NotasFiscais_RPS, ErrosLista.NotasFiscais_RPS);
                    Validacoes.CheckArgumentLength(this.NotasFiscais_RPS, 1, 87, ErrosLista.NotasFiscais_RPS);

                    Validacoes.CheckArgumentNotEmpty(this.NotasFiscais_Lote, ErrosLista.NotasFiscais_Lote);
                    Validacoes.CheckArgumentNotNull(this.NotasFiscais_Lote, ErrosLista.NotasFiscais_Lote);
                    Validacoes.CheckArgumentLength(this.NotasFiscais_Lote, 1, 87, ErrosLista.NotasFiscais_Lote);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.NotasFiscais_Clientes_Id), ErrosLista.Clientes_Id);
                    Validacoes.CheckArgumentNotNull(this.NotasFiscais_Clientes_Id, ErrosLista.Clientes_Nome);

                    Validacoes.CheckArgumentNotEmpty(Convert.ToString(this.NotasFiscais_Clientes_Id), ErrosLista.Clientes_Id);
                    Validacoes.CheckArgumentNotNull(this.NotasFiscais_Clientes_Id, ErrosLista.Clientes_Nome);

                    break;
            }
        }

        //RETORNANDO CONSULTA DE DADOS PARA DATAGREDVIEW
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
                                @"INSERT INTO NotasFiscais (
                                                        [NotasFiscais_Numero]
                                                        ,[NotasFiscais_Status]
                                                        ,[NotasFiscais_DataEmissao]
                                                        ,[NotasFiscais_Assinatura]
                                                        ,[NotasFiscais_Motivo]
                                                        ,[NotasFiscais_Protocolo]
                                                        ,[NotasFiscais_Verificacao]
                                                        ,[NotasFiscais_RPS]
                                                        ,[NotasFiscais_Lote]
                                                        ,[NotasFiscais_DtAtualizacao]
                                                        ,[NotasFiscais_DtCadastro]
                                                        ,[NotasFiscais_Clientes_Id]
                                                        ,[NotasFiscais_Clientes_Id_Tomador]) 
                                                    VALUES("
                                                        + @"'" + this.NotasFiscais_Numero + @"',"
                                                        + @"'" + this.NotasFiscais_Status + @"',"
                                                        + @"'" + this.NotasFiscais_DataEmissao + @"',"
                                                        + @"'" + this.NotasFiscais_Assinatura + @"',"
                                                        + @"'" + this.NotasFiscais_Motivo + @"',"
                                                        + @"'" + this.NotasFiscais_Protocolo + @"',"
                                                        + @"'" + this.NotasFiscais_Verificacao + @"',"
                                                        + @"'" + this.NotasFiscais_RPS + @"',"
                                                        + @"'" + this.NotasFiscais_Lote + @"',"
                                                        + @"'" + this.NotasFiscais_DtAtualizacao + @"',"
                                                        + @"'" + this.NotasFiscais_DtCadastro + @"',"
                                                        + @"'" + this.NotasFiscais_Clientes_Id + @"',"
                                                        + @"'" + this.NotasFiscais_Clientes_Id_Tomador + @"')"
                                                    );
        }

        //ATUALIZAR DADOS
        public void Atualizar()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"UPDATE NotasFiscais SET "
                                                    + @"NotasFiscais_Numero ='" + this.NotasFiscais_Numero + @"'"
                                                    + @"NotasFiscais_Status ='" + this.NotasFiscais_Status + @"'"
                                                    + @"NotasFiscais_DataEmissao ='" + this.NotasFiscais_DataEmissao + @"'"
                                                    + @"NotasFiscais_Assinatura ='" + this.NotasFiscais_Assinatura + @"'"
                                                    + @"NotasFiscais_Motivo ='" + this.NotasFiscais_Motivo + @"'"
                                                    + @"NotasFiscais_Protocolo ='" + this.NotasFiscais_Protocolo + @"'"
                                                    + @"NotasFiscais_Verificacao ='" + this.NotasFiscais_Verificacao + @"'"
                                                    + @"NotasFiscais_RPS ='" + this.NotasFiscais_RPS + @"'"
                                                    + @"NotasFiscais_Lote ='" + this.NotasFiscais_Lote + @"'"
                                                    + @"NotasFiscais_Valor ='" + this.NotasFiscais_Valor + @"'"
                                                    + @"NotasFiscais_DtAtualizacao ='" + this.NotasFiscais_DtAtualizacao + @"'"
                                                    + @"NotasFiscais_DtCadastro ='" + this.NotasFiscais_DtCadastro + @"'"
                                                    + @"NotasFiscais_Cidades_Id ='" + this.NotasFiscais_Clientes_Id + @"'"
                                                    + @"NotasFiscais_Clientes_Id_Tomador ='" + this.NotasFiscais_Clientes_Id_Tomador + @"'"
                                                    + @" WHERE (NotasFiscais_Id = '" + this.NotasFiscais_Id + @"')");
        }

        //REMOVER DADOS
        public void Remover()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(@"DELETE FROM NotasFiscais WHERE (NotasFiscais_Clientes_Id = '" + this.NotasFiscais_Clientes_Id + @"')");
        }
                     
        #endregion

    }


}
