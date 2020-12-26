using CalculateMealForMyBaby.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateMealForMyBaby.ViewModels
{
    public class BabyViewModel
    {
        public Baby Baby { get; set; }
        public IEnumerable<Foods> RenderFoods { get; set; }
        public int Value { get; set; }
    }
}
