using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvalAdanArdaya.Models
{
    public class Courrency
    {
        [key]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(5,MinimumLength =1-5,ErrorMessage ="Ingrese entre 1 a 5 caracteres ")]
         public int Symbol { get; set; }
}
}