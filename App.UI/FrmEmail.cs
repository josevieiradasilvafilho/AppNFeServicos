using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace App.UI
{
    public partial class FrmEmail : Form
    {
        public FrmEmail()
        {
            InitializeComponent();
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {

            //https://wiki.locaweb.com.br/pt-br/Envio_de_e-mails_via_.NET_utilizando_o_System.Net.Mail'
            //https://msdn.microsoft.com/en-us/library/system.net.mail.mailmessage.aspx
            //https://wiki.locaweb.com.br/pt-br/Envio_de_e-mails_via_.NET_utilizando_o_System.Web.Mail

            string EmailRetorno = "";

            string EmailDestino = @"zezinhosjc@gmail.com";
            string EmailAssunto = @"Testes de Nfs";
            string EmailMensagem = @"123testando";
            string EmailOrigem = @"jvsilvafilho@josevieiras.com.br";
            
            string EmailOrigemPsw = @"101418jvsf";
            string Emailsmtp = "smtp.josevieiras.com.br";
            string EmailNomeRemetente = "Jose Vieira";

            //Cria objeto com dados do e-mail.
            MailMessage oMailMessage = new MailMessage();

            //Define o Campo From e ReplyTo do e-mail.
            oMailMessage.From = new MailAddress(EmailNomeRemetente + "<" + EmailOrigem + ">");

            //Define os destinatários do e-mail.
            oMailMessage.To.Add(EmailDestino);

            //Enviar cópia para.
            //objEmail.CC.Add(emailComCopia);
            
            //Enviar cópia oculta para.
            oMailMessage.Bcc.Add(EmailOrigem);

            //Define a prioridade do e-mail.
            oMailMessage.Priority = MailPriority.Normal;

            //Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
            oMailMessage.IsBodyHtml = true;
            
            //Define título do e-mail.
            oMailMessage.Subject = EmailAssunto;

            //Define o corpo do e-mail.
            oMailMessage.Body = EmailMensagem;
            
            // Caso queira enviar um arquivo anexo
            //Caminho do arquivo a ser enviado como anexo
            //string arquivo = Server.MapPath("arquivo.jpg");

            // Ou especifique o caminho manualmente
            //string arquivo = @"e:\home\LoginFTP\Web\arquivo.jpg";

            // Cria o anexo para o e-mail
            //Attachment oAttachment = new Attachment(arquivo, System.Net.Mime.MediaTypeNames.Application.Octet);

            // Anexa o arquivo a mensagem
            //oMailMessage.Attachments.Add(oAttachment);

            //Para evitar problemas de caracteres "estranhos", configuramos o charset para "ISO-8859-1"
            oMailMessage.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
            oMailMessage.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
            
            //Cria objeto com os dados do SMTP
            SmtpClient oSmtpClient = new SmtpClient(Emailsmtp, 587);
            
            //Alocamos o endereço do host para enviar os e-mails  
            oSmtpClient.Credentials = new NetworkCredential(EmailOrigem, EmailOrigemPsw);//e-mail e senha do remetente
            
            //Caso utilize conta de email do exchange da locaweb deve habilitar o SSL
            //objEmail.EnableSsl = true;
            
            try
            {
                //Enviamos o e-mail através do método .send()
                oSmtpClient.Send(oMailMessage);
                EmailRetorno = "mensagem de exito";
                var msgErros = MessageBox.Show(EmailRetorno, @"Email!",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Question);
                //oMailMessage.Dispose();
            }
            catch (Exception ex)
            {
                var msgErros = MessageBox.Show(ex.Message, @"Email!",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);
            }
            finally
            {
                //Exclui o obj email da memória
                oMailMessage.Dispose();
            }
        }
    }
}
