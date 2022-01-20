using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Threading.Tasks;


namespace MyFirstASPNetWebApp.Models
//namespace RangeValidationAPI.Models
{
    public class CalculatorModel
    {
        
        [Required(ErrorMessage = "Please enter your number")]
        [Range(0, 100, ErrorMessage = "*Enter a number between 0 and 100*")]
        public int assign { get; set; }
        public int group { get; set; }
        public int quiz { get; set; }
        public int exam { get; set; }
        public int intex { get; set; }
    }
}
