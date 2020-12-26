using CalculateMealForMyBaby.Models;
using CalculateMealForMyBaby.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateMealForMyBaby.Controllers
{
    public class BabyController : Controller
    { //rano przeanalizowac kontroler z formularzem w MattsRestaurant by jakos tutaj zaimplementowac
        private readonly IBabyRepository _babyRepository;
        private IEnumerable<Foods> GetFoods { get; set; }
        public BabyController(IBabyRepository babyRepository)
        {
            _babyRepository = babyRepository;
        }

        public IActionResult BadSubmit(Baby baby)
        {
            return View(new BabyViewModel()
            {
                Baby = baby,
            });
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Baby baby)
        {
            if (ModelState.IsValid)
            {
                if(baby.MonthOfBirth < 5 && baby.Weight > 11 && baby.Height > 75 || baby.MonthOfBirth >= 5 && baby.Height < 60 && baby.Weight < 5.5)
                {
                    return RedirectToAction("BadSubmit");
                }
                _babyRepository.SubmitBaby(baby);
                return RedirectToAction("CheckForm");
            }
            return View(baby);
        }
        public IActionResult CheckForm()
        {
            ViewBag.YourChoice = "Our suggestion";
            BabyViewModel viewModel = new BabyViewModel
            {
                Value = _babyRepository.CalculateSum,
                RenderFoods = _babyRepository.ChoiceFoods
                
            };
            return View(viewModel);
        }
    }
}
