using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Interfaces;
using Vkusno_Doma.Data.Models;

namespace Vkusno_Doma.Data.Repository
{
    public class FoodRepository : IAllFoods
    {
        private readonly AppDBContent appDBContent;

        public FoodRepository(AppDBContent _appDBContent)
        {
            this.appDBContent = _appDBContent;
        }

        public IEnumerable<Food> IFoods => appDBContent.Food.Include(c => c.Category);

        public IEnumerable<Food> IGetFoods  => appDBContent.Food.Where(p => p.IsFavorite).Include(c => c.Category);

        public Food GetObjectFood(int FoodId) => appDBContent.Food.FirstOrDefault(p=>p.Id == FoodId);
       
    }
}
