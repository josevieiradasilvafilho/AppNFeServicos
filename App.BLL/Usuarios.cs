using System;
using App.Common.Validation;
using App.Common.Resources;
using App.DAL;
using System.Data;

namespace App.BLL
{
    public class Usuarios
    {

        #region PROPRIEDADES
        public int Usuarios_Id { get; private set; }
        public string Usuarios_Usuario { get; private set; }
        public string Usuarios_Email { get; private set; }
        public string Usuarios_Senha { get; private set; }
        public string Usuarios_ConfirmarSenha { get; private set; }
        public bool Usuarios_Administrador { get; private set; }
        public DateTime DtAtualizacao { get; set; }
        public DateTime DtCadastro { get; set; }
        public string Scopo { get; set; }
        #endregion

        #region CONSTRUTOR
        public Usuarios(int usuarios_Id
                            ,string usuarios_Usuario
                            , string usuarios_Email
                            , string usuarios_Senha
                            , string usuarios_ConfirmarSenha
                            , bool usuarios_Administrador
                            , DateTime dtAtualizacao
                            , DateTime dtCadastro
                            , string scopo
                            )
        {
                this.Usuarios_Id = usuarios_Id;
                this.Usuarios_Usuario = usuarios_Usuario;
                this.Usuarios_Email = usuarios_Email;
                this.Usuarios_Senha = usuarios_Senha;
                this.Usuarios_ConfirmarSenha = usuarios_ConfirmarSenha;
                this.Usuarios_Administrador = usuarios_Administrador;
                this.DtAtualizacao = dtAtualizacao;
                this.DtCadastro = dtCadastro;
                this.Scopo = scopo;
        }
        #endregion

        #region MÉTODOS
        public void SetDados()
            {
            switch (this.Scopo)
            {
                case @"Excluir":

                    Validacoes.CheckArgumentNotEmpty(this.Usuarios_Usuario, ErrosLista.Usuarios_Usuario);
                    Validacoes.CheckArgumentNotNull(this.Usuarios_Usuario, ErrosLista.Usuarios_Usuario);
                    Validacoes.CheckArgumentLength(this.Usuarios_Usuario, 6, 20, ErrosLista.Usuarios_Usuario);
                    break;

                default:

                    Validacoes.CheckArgumentNotEmpty(this.Usuarios_Usuario, ErrosLista.Usuarios_Usuario);
                    Validacoes.CheckArgumentNotNull(this.Usuarios_Usuario, ErrosLista.Usuarios_Usuario);
                    Validacoes.CheckArgumentLength(this.Usuarios_Usuario, 6, 20, ErrosLista.Usuarios_Usuario);

                    //VALIDAR EMAIL
                    Validacoes.CheckArgumentNotEmpty(this.Usuarios_Email, ErrosLista.Email_Invalido);
                    Validacoes.CheckArgumentNotNull(this.Usuarios_Email, ErrosLista.Email_Invalido);
                    Validacoes.CheckArgumentLength(this.Usuarios_Email, 5, 40, ErrosLista.Email_Invalido);
                    Validacoes.CheckArgumentEmail(this.Usuarios_Email, ErrosLista.Email_Invalido); ;
                    //ValidacoesEmail.CheckEmailIsValid(this.Email_Invalido);

                    //VERIFICA A SENHA É NULA
                    Validacoes.CheckArgumentNotNull(this.Usuarios_Senha, ErrosLista.Usuarios_Senha);
                    Validacoes.CheckArgumentNotEmpty(this.Usuarios_Senha, ErrosLista.Usuarios_Senha);
                    Validacoes.CheckArgumentLength(this.Usuarios_Senha, 6, 32, ErrosLista.Usuarios_Senha);

                    Validacoes.CheckArgumentNotNull(this.Usuarios_ConfirmarSenha, ErrosLista.Usuarios_ConfirmarSenha);
                    Validacoes.CheckArgumentNotEmpty(this.Usuarios_ConfirmarSenha, ErrosLista.Usuarios_ConfirmarSenha);
                    Validacoes.CheckArgumentLength(this.Usuarios_ConfirmarSenha, 6, 32, ErrosLista.Usuarios_ConfirmarSenha);
                    Validacoes.CheckArgumentEquals(this.Usuarios_Senha, this.Usuarios_ConfirmarSenha, ErrosLista.Usuarios_ConfirmarSenha);
                    
                    Validacoes.CheckArgumentNotNull(this.Usuarios_Administrador, ErrosLista.Usuarios_Perfil);
                 
                    //RETORNO DA SENHA
                    break;
            }
        }

        public DataTable GetDados(string SQL)
        {
            
           Banco oBanco = new Banco();
           return oBanco.GetDatatable(SQL);

        }

        public void Inserir()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"INSERT INTO USUARIOS ([Usuarios_Usuario],[Usuarios_Email],[Usuarios_Senha],[Usuarios_Administrador],[Usuarios_DtInclusao],[Usuarios_DtAtualizacao]) VALUES("
                                + @"'" + this.Usuarios_Usuario + @"',"
                                + @"'" + this.Usuarios_Email + @"',"
                                + @"'" + ValidacoesSenha.Encrypt(this.Usuarios_Senha) + @"',"
                                + @"'" + this.Usuarios_Administrador + @"',"
                                + @"'" + this.DtCadastro + @"',"
                                + @"'" + this.DtAtualizacao + @"')");
            
        }

        public void Atualizar()
        {
            Banco oBanco = new Banco();
            
            oBanco.ComandoSQL(
                                @"UPDATE USUARIOS SET "
                                + @"Usuarios_Usuario ='" + this.Usuarios_Usuario + @"',"
                                + @"Usuarios_Email ='" + this.Usuarios_Email + @"',"
                                + @"Usuarios_Senha ='" + ValidacoesSenha.Encrypt(this.Usuarios_Senha) + @"',"
                                + @"Usuarios_Administrador ='" + this.Usuarios_Administrador + @"',"
                                + @"Usuarios_DtAtualizacao = '" + this.DtAtualizacao + @"' "
                                + @"WHERE Usuarios_Id = '" + this.Usuarios_Id + @"'");

        }

        public void Remover()
        {
            Banco oBanco = new Banco();
            oBanco.ComandoSQL(
                                @"DELETE FROM USUARIOS "
                                + @"WHERE Usuarios_Id = '" + this.Usuarios_Id + @"'");

        }
        
        #endregion

    }
    
}
