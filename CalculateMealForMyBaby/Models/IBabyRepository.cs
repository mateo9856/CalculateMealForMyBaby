using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateMealForMyBaby.Models
{
    public interface IBabyRepository
    {
        void SubmitBaby(Baby baby);
        public IEnumerable<Foods> ChoiceFoods { get; set; }
        int CalculateSum { get; set; }
    }
}
