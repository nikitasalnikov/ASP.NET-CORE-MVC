using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Interfaces;
using Vkusno_Doma.Data.Models;
using Vkusno_Doma.ViewModels;

namespace Vkusno_Doma.Controllers
{
    public class FoodCartController : Controller
    {
        private readonly IAllFoods _foodRep;
        private readonly FoodCart _foodCart;

        public FoodCartController(IAllFoods foodRepository, FoodCart foodCart)
        {
            _foodRep = foodRepository;
            _foodCart = foodCart;
        }

        public ViewResult FoodCartIndex()
        {
            var items = _foodCart.getFoodItems();
            _foodCart.listFoodItem = items;

            var obj = new FoodCartViewModel
            {
                foodCart = _foodCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int Id)
        {
            var item = _foodRep.IFoods.FirstOrDefault(i=> i.Id == Id);
            if(item != null)
            {
                _foodCart.AddToCart(item);
            }
            return RedirectToAction("FoodCartIndex");
        }
       
    }
}
