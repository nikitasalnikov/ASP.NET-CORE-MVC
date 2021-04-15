using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Interfaces;
using Vkusno_Doma.ViewModels;

namespace Vkusno_Doma.Controllers
{
    public class FoodsController : Controller
    {
        private readonly IAllFoods _allFoods;
        private readonly IFoodsCategory _allCategories;

        public FoodsController(IAllFoods IallFoods, IFoodsCategory IfoodsCategory)
        {
            _allFoods = IallFoods;
            _allCategories = IfoodsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Вкусно как дома";
            FoodListViewModel obj = new FoodListViewModel();
            obj.AllFood = _allFoods.IFoods;
            obj.currentCategory = "Наименование и цены";
            return View(obj);
        }
    }
}
