using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WFBaseDados.Entidades
{
    [Table("WFCategoria")]
    public class WFCategoria
    {
        [Key]
        public int PK_WFCategoria { get; set; }
        public string Nome { get; set; }

        [Editable(false)]
        public ValidationResult ValidationResult { get; set; }
    }
}
