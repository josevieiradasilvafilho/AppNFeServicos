using System;
using System.Text.RegularExpressions;
using App.Common.Resources;

namespace App.Common.Validation
{
    public class ValidacoesEmail
    {
        public static void CheckEmailIsValid(string email)
        {
            if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                throw new Exception(ErrosLista.Email_Invalido);
        }
    }
}
