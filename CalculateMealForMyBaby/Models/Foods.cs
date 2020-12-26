using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateMealForMyBaby.Models
{
    public class Foods
    {
        public int FoodId { get; set; }
        public string TimeOfDay { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
    }
}
