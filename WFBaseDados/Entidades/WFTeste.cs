using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;

namespace WFBaseDados.Entidades
{
    public class WFTeste
    {
        public int PK_WFTeste { get; set; }
        public string Propriedade { get; set; } 
        public string Valor { get; set; }

        public Validacao Validacao{ get; set; }
    }
}
