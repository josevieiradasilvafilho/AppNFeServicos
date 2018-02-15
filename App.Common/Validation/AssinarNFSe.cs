using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace App.Common.Validation
{
    public class AssinarNFSe
    {
        public string SignRPS(X509Certificate2 cert, String sAssinatura)
        {
            
            //recebe o certificado e a string a ser assinada 
            ASCIIEncoding enc = new ASCIIEncoding();

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //pega a chave privada do certificado digital 
            rsa = cert.PrivateKey as RSACryptoServiceProvider;

            //cria o array de bytes e realiza a conversao da string em array de bytes 
            byte[] sAssinaturaByte = enc.GetBytes(sAssinatura);

            RSAPKCS1SignatureFormatter rsaf = new RSAPKCS1SignatureFormatter(rsa);
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            //cria a variavel hash que armazena o resultado do sha1 
            byte[] hash;
            hash = sha1.ComputeHash(sAssinaturaByte);

            //definimos o metodo a ser utilizado na criptografia e assinamos 
            rsaf.SetHashAlgorithm("SHA1");
            sAssinaturaByte = rsaf.CreateSignature(hash);

            //por fim fazemos a conversao do array de bytes para string 
            string convertido;
            convertido = Convert.ToBase64String(sAssinaturaByte);

            return convertido;
        }
    }
}
