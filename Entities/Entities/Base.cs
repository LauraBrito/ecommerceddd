﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Base : Notifies
    {
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
