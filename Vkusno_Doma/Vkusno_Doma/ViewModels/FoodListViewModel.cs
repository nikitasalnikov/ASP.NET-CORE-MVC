using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Models;

namespace Vkusno_Doma.ViewModels
{
    public class FoodListViewModel
    {
        public IEnumerable<Food> AllFood { get; set; }

        public string currentCategory { get; set; }
    }
}
