using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Interfaces;
using Vkusno_Doma.Data.Models;

namespace Vkusno_Doma.Data.Repository
{
    public class CategoryRepository : IFoodsCategory
    {

        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent _appDBContent)
        {
            this.appDBContent = _appDBContent;
        }
        public IEnumerable<Category> IAllcategories => appDBContent.Category;
    }
}
