using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WFBase.Base
{
    public static class Extensao
    {
        public static string ObterValorOuPadrao(this string str, string padrao = "")
        {
            string ret = "";
            if (string.IsNullOrEmpty(str))
            {
                ret = padrao;
                goto Sair;
            }

            if (string.IsNullOrWhiteSpace(str))
            {
                ret = padrao;
                goto Sair;
            }

            if (str.Trim().Length <= 0)
            {
                ret = padrao;
                goto Sair;
            }

            if (str.Trim().Length > 0)
                ret = str.Trim();

        Sair:;
            return ret;
        }
        public static int ObterValorOuPadrao(this string str, int padrao = 0)
        {
            if (string.IsNullOrEmpty(str))
            {
                return padrao;
            }

            if (int.TryParse(str.Trim(), out int valor))
            {
                return valor;
            }

            return padrao;
        }
        public static decimal ObterValorOuPadrao(this string str, decimal padrao = 0m)
        {
            if (string.IsNullOrEmpty(str))
            {
                return padrao;
            }

            if (decimal.TryParse(str.Trim(), out decimal valor))
            {
                return valor;
            }

            return padrao;
        }

    }
}
