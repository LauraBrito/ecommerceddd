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
        [Column("Id")]
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        [Column("Name")]
        [Display(Name = "Nome")]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(255)]
        [Column("Description")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Column("Note")]
        [Display(Name = "Observação")]
        [MaxLength(2000)]
        public string Note { get; set; }

        [Column("Value")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "Usuário")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        public DateTime DateUpdated { get; set; }

        [Column("Iventary")]
        [Display(Name = "Estoque")]
        public int Inventary { get; set; }

        [Column("Status")]
        [Display(Name = "Status")]
        public bool Status { get; set; }
    }
}
