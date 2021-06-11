using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class Notifies
    {
        [NotMapped]
        public string NameProperty { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notifies> Notifications = new List<Notifies>();

        public Notifies()
        {
        }

        public bool ValidateStringProp(string value, string nameProp)
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(nameProp))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Campo obrigatório",
                    NameProperty = nameProp
                });

                return false;
            }

            return true;
        }

        public bool ValidateIntProp(int value, string nameProp)
        {
            if(value < 1 || string.IsNullOrWhiteSpace(nameProp))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Valor deve ser maior que 0",
                    NameProperty = nameProp
                });

                return false;
            }

            return true;
        }

        public bool ValidateDecimalProp(decimal value, string nameProp)
        {
            if(value < 1 || string.IsNullOrWhiteSpace(nameProp))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Valor deve ser maior que 0",
                    NameProperty = nameProp
                });

                return false;
            }

            return true;
        }

    }
}
