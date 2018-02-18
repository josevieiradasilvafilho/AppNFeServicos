using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Common.Validation
{
    public class Uteis
    {
        

        public static void PulaProxCampoTabIndex()
        {
            throw new NotImplementedException();
        }

        public string GetRegexRemAssentuacao(string sCadeia)
        {
            //MAIUSCULA
            sCadeia = sCadeia.ToUpper();

            //REMOVER ACENTUAÇÃO
            StringBuilder oStringBuilder = new StringBuilder();
            string stringNormalizada = sCadeia.Normalize(NormalizationForm.FormD);

            for (int k = 0; k < stringNormalizada.Length; k++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stringNormalizada[k]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    oStringBuilder.Append(stringNormalizada[k]);
                }
            }

            return oStringBuilder.ToString();

        }
    }
}
