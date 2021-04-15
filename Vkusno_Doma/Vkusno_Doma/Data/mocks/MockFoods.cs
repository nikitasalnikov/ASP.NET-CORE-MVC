using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Interfaces;
using Vkusno_Doma.Data.Models;

namespace Vkusno_Doma.Data.mocks
{
    public class MockFoods : IAllFoods
    {
        private readonly IFoodsCategory _foodsCategory = new MockCategory(); // данная переменная указывает к какой категории принадлежит объект
        public IEnumerable<Food> IFoods 
        {

            get
            {
                return new List<Food>
                {
                    new Food{
                        Name ="Котлеты", 
                        ShortDescription="Мясные", 
                        LongDescription="Котлеты мясные - 90 гр. 1шт. ", 
                        Img ="/img/котлеты мясные.jpg", 
                        Price = 8500, 
                        IsFavorite = true , 
                        Available = true, 
                        Category = _foodsCategory.IAllcategories.First()},
                    new Food {
                        Name ="Котлеты", 
                        ShortDescription="Куриные", 
                        LongDescription="Котлеты куриные - 90 гр. 1шт. ", 
                        Img ="/img/котлеты куриные.jpg",
                        Price = 3600, 
                        IsFavorite = true , 
                        Available = true, 
                        Category = _foodsCategory.IAllcategories.First()},
                    new Food{
                        Name ="Котлеты", 
                        ShortDescription="Киевские", 
                        LongDescription="Котлеты киевские - 135 гр. 1шт. ", 
                        Img ="/img/котлеты по киевски.jpg",
                        Price = 6500, 
                        IsFavorite = true , 
                        Available = true, 
                        Category = _foodsCategory.IAllcategories.First()},
                    new Food{
                        Name ="Манты", 
                        ShortDescription="Мясные", 
                        LongDescription="Манты мясные - 0,5кг. развесные. ", 
                        Img ="/img/манты мясо и мясо с картошкой.jpg",
                        Price = 27000, 
                        IsFavorite = true , 
                        Available = true, 
                        Category = _foodsCategory.IAllcategories.First()},
                    new Food{
                        Name ="Манты", 
                        ShortDescription="Мясные", 
                        LongDescription="Манты мясные - 1 кг. развесные", 
                        Img ="/img/манты мясо и мясо с картошкой.jpg",
                        Price = 54000, 
                        IsFavorite = true , 
                        Available = true, 
                        Category = _foodsCategory.IAllcategories.First()},
                    new Food{
                        Name ="Манты", 
                        ShortDescription="Картошка-мясо", 
                        LongDescription="Манты картошка-мясо - 0,5кг. развесные. ", 
                        Img ="/img/манты мясо и мясо с картошкой.jpg",
                        Price = 22000, 
                        IsFavorite = true , 
                        Available = true, 
                        Category = _foodsCategory.IAllcategories.First()},
                    new Food{
                        Name ="Манты",
                        ShortDescription="Картошка-мясо",
                        LongDescription="Манты картошка-мясо - 1кг. развесные. ",
                        Img ="/img/манты мясо и мясо с картошкой.jpg",
                        Price = 44000,
                        IsFavorite = true ,
                        Available = true,
                        Category = _foodsCategory.IAllcategories.First()},
                    new Food{
                        Name ="Манты",
                        ShortDescription="тыква",
                        LongDescription="Манты тыква - 0,5кг. развесные. ",
                        Img ="/img/манты с тыквой.jpg",
                        Price = 17000,
                        IsFavorite = true ,
                        Available = true,
                        Category = _foodsCategory.IAllcategories.First()},
                    new Food{
                        Name ="Манты",
                        ShortDescription="Тыква",
                        LongDescription="Манты тыква - 1кг. развесные. ",
                        Img ="/img/манты с тыквой.jpg",
                        Price =34000,
                        IsFavorite = true ,
                        Available = true,
                        Category = _foodsCategory.IAllcategories.First()},
                };
            }
        }
        public IEnumerable<Food> IGetFoods { get; set; }

        public Food GetObjectFood(int FoodId)
        {
            throw new NotImplementedException();
        }
    }
}
