using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vkusno_Doma.Data.Models
{
    public class Food
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string Img { get; set; }

        public double Price { get; set; }

        public bool IsFavorite { get; set; }// если true отображается на главной страничке, если false то нет

        public bool Available { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
