using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;

namespace WFBaseDados
{
    internal static class Program
    {
        public static bool IniciarBaseDados()
        {
            ValidationResult validation = new ValidationResult();
            
            CriarConexao(validation);
            CriarTabelasBase(validation);

            return validation.Errors.Count() <= 0;
        }

        private static void CriarConexao(ValidationResult validation)
        {

        }

        private static void CriarTabelasBase(ValidationResult validation)
        {

        }
    }
}

