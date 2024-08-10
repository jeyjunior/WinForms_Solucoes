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
using WFBaseDados.Entidades.Config;
using WFBaseDados.Interfaces;

namespace WFBaseDados
{
    internal static class Program
    {
        public static bool IniciarBaseDados()
        {
            ValidationResult validation = new ValidationResult();
            var configuracaoBancoDados = BootstrapBaseDados.Container.GetInstance<IConfiguracaoBancoDados>();
            var teste = configuracaoBancoDados.ObterStringConexao();
            return validation.Errors.Count() <= 0;
        }
    }
}

