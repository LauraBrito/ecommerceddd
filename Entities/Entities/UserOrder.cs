using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class UserOrder : Notifies
    {
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        [Display(Name = "Status")]
        public int Status { get; set; }

        [ForeignKey("Product")]
        [Display(Name = "Produto")]
        [Column(Order = 1)]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Display(Name = "Status de compra")]
        public StatusOrder StatusPurchase { get; set; }

        [Display(Name = "Quantidade")]
        public int Amount { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "Usuário")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
