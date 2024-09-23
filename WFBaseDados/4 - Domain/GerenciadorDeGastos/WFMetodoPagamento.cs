using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WFBase.Base;

namespace WFBaseDados.Entidades
{
    [Table("WFMetodoPagamento")]
    public class WFMetodoPagamento
    {
        [Key]
        public int PK_WFMetodoPagamento { get; set; }
        public string Nome { get; set; }

        [Editable(false)]
        public Validacao Validacao { get; set; }
    }
}
