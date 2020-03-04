using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Models
{
    public class MailModel
    {
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        public string Name
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        [EmailAddress(ErrorMessage = "Hatalı mail adresi")]
        public string Mail
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        public string Subject
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        public string Message
        {
            get;
            set;
        }
        public string PhoneNo
        {
            get;
            set;
        }
    }
}
