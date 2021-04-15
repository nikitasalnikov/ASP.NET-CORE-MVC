using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vkusno_Doma.Data.Models
{
    public class FoodCartItem
    {
        public int Id { get; set; }
        public Food food { get; set; }
        public double price { get; set; }

        public string FoodCartId { get; set; }
    }
}
