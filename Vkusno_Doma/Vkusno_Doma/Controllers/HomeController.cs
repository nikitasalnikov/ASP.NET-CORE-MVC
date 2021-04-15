using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Interfaces;
using Vkusno_Doma.ViewModels;

namespace Vkusno_Doma.Controllers
{
    public class HomeController : Controller
    {
        private IAllFoods _foodrep;

        public HomeController(IAllFoods allFoods)
        {
            _foodrep = allFoods;
        }

        public ViewResult Index()
        {
            var homeFood = new HomeViewModel
            {
                favoriteFoods = _foodrep.IGetFoods
            };
            return View(homeFood);
        }
    }
}
