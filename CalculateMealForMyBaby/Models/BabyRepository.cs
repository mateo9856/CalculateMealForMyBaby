using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateMealForMyBaby.Models
{
    public class BabyRepository : IBabyRepository
    {
        public int CalculateSum { get; set; } = 0;
        public IEnumerable<Foods> ChoiceFoods { get; set; }
        public List<Foods> foodsList = new List<Foods>
        {
            new Foods{FoodId = 1, TimeOfDay = "Breakfast", FoodName = "Porridge with milk", Description = "The basis of a good start to the day is a solid dish composed of dairy products, the best dish is porridge with milk.", Points = 1},
            new Foods{FoodId = 2, TimeOfDay = "Breakfast", FoodName = "Oatmeal", Description = "Oatmeal is a solid breakfast, it contains many vitamins that will stimulate you with a desire to start your day.", Points = 2},
            new Foods{FoodId = 3, TimeOfDay = "Breakfast", FoodName = "Cheeses", Description = "They contain a lot of calcium and protein and keep your baby healthy and prevent obesity", Points = 3},
            new Foods{FoodId = 4, TimeOfDay = "Second Breakfast", FoodName = "Light sanwitches", Description ="The second breakfast is the basis for proper functioning, but the best dish is light dishes, easy-to-digest bread is the best solution.", Points = 1},
            new Foods{FoodId = 5, TimeOfDay = "Second Breakfast", FoodName = "Dairy products: youghurts etc.", Description = "Lunch is a light meal that supports the child's development, the best of which are nutritious and protein-enriched dairy products such as yoghurt, cheese and kefir.", Points = 2},
            new Foods{FoodId = 6, TimeOfDay = "Second Breakfast", FoodName = "Fruits", Description = "Before lunch, it is worth providing the child with a lot of vitamins that are found in fruits, fruits improve energy and take care not to lead to obesity", Points = 3},
            new Foods{FoodId = 7, TimeOfDay = "Dinner", FoodName = "Soups full of vitamins", Description = "Soups undoubtedly belong to the dishes required for proper functioning, they maintain the proper development of the child and bones", Points = 1},
            new Foods{FoodId = 8, TimeOfDay = "Dinner", FoodName = "Main dish", Description = "A juicy dinner gives a specific kick to the energy demand, remember that the dish should be even, so it's best not to overdo it with a lot of meat", Points = 2},
            new Foods{FoodId = 9, TimeOfDay = "Dinner", FoodName = "Baked fish", Description = "It can be served with potatoes and salad provides a lot of vitamins strengthens the body and bones and cares for the proper development of the child", Points = 3 },
            new Foods{FoodId = 10, TimeOfDay = "Before Dinner", FoodName = "Fruits", Description = "Refreshing fruit full of vitamins helps to improve well-being and gives the right balance between lunch and dinner!", Points = 1},
            new Foods{FoodId = 11, TimeOfDay = "Before Dinner", FoodName = "Sandwiches", Description = "Afternoon tea and a sandwich are a good combination - light bread combined with light ham or dairy products is a good combination.", Points = 2},
            new Foods{FoodId = 12, TimeOfDay = "Before Dinner", FoodName = "Yoghurts, kefirs", Description = "Before dinner, a good portion to strengthen your bones is useful. Eating yoghurt and kefir is highly recommended!", Points = 3},
            new Foods{FoodId = 13, TimeOfDay = "Supper", FoodName = "Porridge", Description = "For bedtime, porridges are food full of vitamins, but also a great idea for a good night.", Points = 1},
            new Foods{FoodId = 14, TimeOfDay = "Supper", FoodName = "Dairies", Description = "Dairy products are of course the best dish for a child, they help in development and children fall asleep and sleep faster and more calmly", Points = 2},
            new Foods{FoodId = 15, TimeOfDay = "Supper", FoodName = "Pancakes", Description = "Satisfaction is important, pancakes ensure that the little baby will be full and will not wake up at night from hunger.", Points = 3},
        };
        
        public void SubmitBaby(Baby baby)
        {
            AddSummaryPoints(baby);
            int point = 1;
            if (CalculateSum <= 110)
                point = 1;
            else if (CalculateSum > 110 && CalculateSum <= 140)
                if(baby.MonthOfBirth < 4)
                {
                    point = 1;
                } 
                else
                {
                    point = 2;
                }
            else if (CalculateSum > 140)
                if(baby.MonthOfBirth < 7)
                {
                    point = 2;
                }
                else
                {
                    point = 3;
                }
            ChoiceFoods = from d in foodsList
                   where d.Points == point
                   select d;
        
        }

        private void AddSummaryPoints(Baby baby)
        {
            if(baby.Gender == "Boy")
            {
                CalculateSum = (int)(baby.Height + (baby.Weight * baby.MonthOfBirth));
            } else
            {
                CalculateSum = (int)(baby.Height + (baby.Weight * (baby.MonthOfBirth / 1.5)));
            }
            
        }

    }
}
