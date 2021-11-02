using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadanie_praktyczne.Models
{
    public class Person
    {
        [Display(Name = "Nick Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Tylko litery")]
        [StringLength(30, ErrorMessage = "Maksymalnie {1} znaków")]
        public string NickName { get; set; }

        [Display(Name = "Adres e-mail")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        [EmailAddress(ErrorMessage = "To nie jest poprawny adres e-mail")]
        public string EmailAddress { get; set; }
        
    }
}
