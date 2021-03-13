using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvalAdanArdaya.Models
{
    public class Country
    {
        [key]
        public string Name { get; set; }
        [Required]
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<double>  MyProperty { get; set; }
        public List<string>  Timezones { get; set; }
        public List<Courrency> Courrency { get; set; }
     
    }
}