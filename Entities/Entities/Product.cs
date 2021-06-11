using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Product")]
    public class Product : Notifies
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        [Column("PRD_NAME")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("PRD_VALUE")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Column("PRD_STATUS")]
        [Display(Name = "Status")]
        public bool Status { get; set; }
    }
}
