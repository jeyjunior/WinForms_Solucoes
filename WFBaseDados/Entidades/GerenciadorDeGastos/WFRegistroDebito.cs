using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Base;

namespace WFBaseDados.Entidades
{
    [Table("WFRegistroDebitos")]
    public class WFRegistroDebito
    {
        [Key]
        public int PK_WFRegistroDebito { get; set; }
        public string Nome { get; set; }
        public DateTime DataDebito { get; set; }
        public decimal Valor { get; set; }
        public int? FK_WFCategoria { get; set; }
        public int? FK_WFMetodoPagamento { get; set; }

        [Editable(false)]
        public WFCategoria WFCategoria { get; set; }
        [Editable(false)]
        public WFMetodoPagamento WFMetodoPagamento { get; set; }

        [Editable(false)]
        public Validacao Validacao { get; set; }
    }

    public class WFRegistroDebitoRequest
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int FK_WFCategoria { get; set; }
        public int FK_WFMetodoPagamento { get; set; }

        public Validacao Validacao { get; set; }
    }
}
