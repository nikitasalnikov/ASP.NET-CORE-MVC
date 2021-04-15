using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vkusno_Doma.Data.Models
{
    public class FoodCart
    {
        private readonly AppDBContent appDBContent;

        public FoodCart(AppDBContent _appDBContent)
        {
            this.appDBContent = _appDBContent;
        }
        public string FoodCartId { get; set; }

        public List<FoodCartItem> listFoodItem { get; set; }

        public static FoodCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string foodCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", foodCartId);

            return new FoodCart(context) { FoodCartId = foodCartId };
        }

        public void AddToCart(Food food)
        {
            appDBContent.foodCartItems.Add(new FoodCartItem
            {
                FoodCartId = FoodCartId,
                food = food,
                price = food.Price
            });
            appDBContent.SaveChanges();
        }
        public List<FoodCartItem> getFoodItems()
        {
            return appDBContent.foodCartItems.Where(c => c.FoodCartId == FoodCartId).Include(s => s.food).ToList();
        }
    }
}
