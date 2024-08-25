using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBaseDados.Entidades
{
    [Table("WFRegistroDebitos")]
    public class WFRegistroDebitos
    {
        [Key]
        public int PK_WFRegistroDebitos { get; set; }
        public string Nome { get; set; }
        public DateTime DataDebito { get; set; }
        public decimal Valor { get; set; }
        public int? FK_WFCategoria { get; set; }
        public int? FK_WFMetodoPagamento { get; set; }

        [Editable(false)]
        public ValidationResult ValidationResult { get; set; }
    }
}
