using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBase.Base
{
    public class Validacao
    {
        public List<string> Erros { get; private set; }

        public bool ehValido
        {
            get { return Erros.Count == 0; }
        }

        public Validacao()
        {
            Erros = new List<string>();
        }

        public void AddErro(string error)
        {
            Erros.Add(error);
        }

        public void AddErros(IEnumerable<string> errors)
        {
            Erros.AddRange(errors);
        }
    }
}
