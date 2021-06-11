using Entities.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Código")]
        public override string Id { get; set; }

        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "Idade")]
        public int Age { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Display(Name = "Endereço")]
        public string Adress { get; set; }

        [Display(Name = "Complemento")]
        public string AdressComplement{ get; set; }

        [Display(Name = "Número de celular")]
        [MaxLength(11, ErrorMessage = "Número de celular incorreto")]
        public override string PhoneNumber { get; set; }

        [Display(Name = "Estado")]
        public string State { get; set; }

        [Display(Name = "Tipo de usuário")]
        public TypeUser Type { get; set; }
    }
}
