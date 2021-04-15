using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Interfaces;
using Vkusno_Doma.Data.Models;

namespace Vkusno_Doma.Data.mocks
{
    public class MockCategory : IFoodsCategory
    {
        public IEnumerable<Category> IAllcategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Полуфабрикаты", Description = "Готовые полуфабрикаты, домашнего приготовления"},
                };
            }
        }
    }
}
