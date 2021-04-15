using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Models;

namespace Vkusno_Doma.Data.Interfaces
{
   public interface IAllFoods
    {
        IEnumerable<Food> IFoods { get;}

        IEnumerable<Food> IGetFoods { get;}

        Food GetObjectFood(int FoodId);
    }
}
