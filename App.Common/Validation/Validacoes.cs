using App.Common.Resources;
using System;
using System.Text.RegularExpressions;

namespace App.Common.Validation
{
    public class Validacoes
    {
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;

            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }
        
        public static void CheckArgumentCpf(string cpf, string message)
        {
            if (IsCpf(cpf)==false)
            {
                throw new InvalidOperationException(message);
            }
        
        }
        
        public static bool validaCnpj(String cnpj)
        {

            Int32[] digitos, soma, resultado;
            Int32 nrDig;
            String ftmt;
            Boolean[] cnpjOk;

            //string cnpj = @"123455CARALHOS!@]#$%¨&*()_[+'-=,`´{^~}?/:;>.<|[!@#$%¨&*()-+=´`{[}^~?/:;.,<>|";
            string tmp1 = Regex.Replace(cnpj, "[!@#$%¨&*()-+=´`{[}^~?/:;.,<>|_qwertyuiopasdfghjklçzxcvbnmQWERTYUIOPASDFGHJKLÇZXCVBNM]+", "");
            string tmp2 = Regex.Replace(tmp1, @"-", @"");
            string tmp3 = Regex.Replace(tmp2, @"[\u2018\u2019\u201a\u201b\u0022\u201c\u201d\u201e\u201f\u301d\u301e\u301f]", "");
            string cpnj = tmp3.Replace("]", "").Replace("'", "");

            cnpj = cnpj.Replace("/", "");
            cnpj = cnpj.Replace(".", "");
            cnpj = cnpj.Replace("-", "");

            if (cnpj == "00000000000000")
            {
                return false;
            }
            else
            {
                ftmt = "6543298765432";
                digitos = new Int32[14];
                soma = new Int32[2];
                soma[0] = 0;
                soma[1] = 0;
                resultado = new Int32[2];
                resultado[0] = 0;
                resultado[1] = 0;
                cnpjOk = new Boolean[2];
                cnpjOk[0] = false;
                cnpjOk[1] = false;
            }

            try
            {

                for (nrDig = 0; nrDig < 14; nrDig++)
                {

                    digitos[nrDig] = int.Parse(cnpj.Substring(nrDig, 1));

                    if (nrDig <= 11)
                    {
                        soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                    }

                    if (nrDig <= 12)
                    {
                        soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                    }

                }

                for (nrDig = 0; nrDig < 2; nrDig++)
                {

                    resultado[nrDig] = (soma[nrDig] % 11);

                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                    {
                        cnpjOk[nrDig] = (digitos[12 + nrDig] == 0);
                    }
                    else
                    {
                        cnpjOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                    }

                }

                return (cnpjOk[0] && cnpjOk[1]);

            }

            catch

            {
                return false;
            }
        }

        public static void CheckArgumentCnpj(String cnpj, string message)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (validaCnpj(cnpj)==false)
                {
                    throw new InvalidOperationException(message);
                }

            }
            else
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentEmail(string email, string message)
        {

            if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                throw new InvalidOperationException(message);
            }
            
        }

        public static void CheckArgumentEquals(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentFalse(bool boolValue, string message)
        {
            if (boolValue)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentLength(string stringValue, int maximum, string message)
        {
            int length = stringValue.Trim().Length;
            if (length > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentLength(string stringValue, int minimum, int maximum, string message)
        {
            if (String.IsNullOrEmpty(stringValue))
                stringValue = String.Empty;

            int length = stringValue.Trim().Length;
            if (length < minimum || length > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentMatches(string pattern, string stringValue, string message)
        {
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(stringValue))
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentNotEmpty(string stringValue, string message)
        {
            if (stringValue == null || stringValue.Trim().Length == 0)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentNotEquals(object object1, object object2, string message)
        {
            if (object1.Equals(object2))
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentNotNull(object object1, string message)
        {
            if (object1 == null)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentRange(double value, double minimum, double maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentRange(float value, float minimum, float maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentRange(int value, int minimum, int maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentRange(long value, long minimum, long maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckArgumentTrue(bool boolValue, string message)
        {
            if (!boolValue)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckStateFalse(bool boolValue, string message)
        {
            if (boolValue)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void CheckStateTrue(bool boolValue, string message)
        {
            if (!boolValue)
            {
                throw new InvalidOperationException(message);
            }
        }

        protected void SelfCheckArgumentEquals(object object1, object object2, string message)
        {
            Validacoes.CheckArgumentEquals(object1, object2, message);
        }

        protected void SelfCheckArgumentFalse(bool boolValue, string message)
        {
            Validacoes.CheckArgumentFalse(boolValue, message);
        }

        protected void SelfCheckArgumentLength(string stringValue, int maximum, string message)
        {
            Validacoes.CheckArgumentLength(stringValue, maximum, message);
        }

        protected void SelfCheckArgumentLength(string stringValue, int minimum, int maximum, string message)
        {
            Validacoes.CheckArgumentLength(stringValue, minimum, maximum, message);
        }

        protected void SelfCheckArgumentMatches(string pattern, string stringValue, string message)
        {
            Validacoes.CheckArgumentMatches(pattern, stringValue, message);
        }

        protected void SelfCheckArgumentNotEmpty(string stringValue, string message)
        {
            Validacoes.CheckArgumentNotEmpty(stringValue, message);
        }

        protected void SelfCheckArgumentNotEquals(object object1, object object2, string message)
        {
            Validacoes.CheckArgumentNotEquals(object1, object2, message);
        }

        protected void SelfCheckArgumentNotNull(object object1, string message)
        {
            Validacoes.CheckArgumentNotNull(object1, message);
        }

        protected void SelfCheckArgumentRange(double value, double minimum, double maximum, string message)
        {
            Validacoes.CheckArgumentRange(value, minimum, maximum, message);
        }

        protected void SelfCheckArgumentRange(float value, float minimum, float maximum, string message)
        {
            Validacoes.CheckArgumentRange(value, minimum, maximum, message);
        }

        protected void SelfCheckArgumentRange(int value, int minimum, int maximum, string message)
        {
            Validacoes.CheckArgumentRange(value, minimum, maximum, message);
        }

        protected void SelfCheckArgumentRange(long value, long minimum, long maximum, string message)
        {
            Validacoes.CheckArgumentRange(value, minimum, maximum, message);
        }

        protected void SelfCheckArgumentTrue(bool boolValue, string message)
        {
            Validacoes.CheckArgumentTrue(boolValue, message);
        }

        protected void SelfCheckStateFalse(bool boolValue, string message)
        {
            Validacoes.CheckStateFalse(boolValue, message);
        }

        protected void SelfCheckStateTrue(bool boolValue, string message)
        {
            Validacoes.CheckStateTrue(boolValue, message);
        }

        protected void SelfCheckArgumentEmail(string email, string message)
        {
            Validacoes.CheckArgumentEmail(email, message);
        }

        protected void SelfCheckArgumentCnpj(string cnpj, string message)
        {
            Validacoes.CheckArgumentCnpj(cnpj, message);
        }

        protected void SelfCheckArgumentCpf(string cnpj, string message)
        {
            Validacoes.CheckArgumentCpf(cnpj, message);
        }

    }

}
