using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateMealForMyBaby.Models
{
    public class Baby
    {
        [Required(ErrorMessage = "Enter the Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter a good value...")]
        [Range(55, 95)]
        public double Height { get; set; }
       [Required(ErrorMessage = "Enter a good value...")]
       [Range(2.5, 14)]
        public double Weight { get; set; }
        [Required(ErrorMessage = "Enter a good value...")]
        [Range(2, 12)]
        public int MonthOfBirth { get; set; }
    }
}
