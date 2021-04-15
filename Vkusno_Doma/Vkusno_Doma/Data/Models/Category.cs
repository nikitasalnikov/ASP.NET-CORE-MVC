﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vkusno_Doma.Data.Models
{
    public class Category
    {
        public int id {get;set;}

        public string categoryName { get; set; }

        public string Description { get; set; }

        public List<Food> foods { get; set; }


    }
}
