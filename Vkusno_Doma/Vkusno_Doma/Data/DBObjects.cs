using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vkusno_Doma.Data.Models;

namespace Vkusno_Doma.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
          
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Food.Any())
            {
                content.AddRange(

                    new Food
                    {
                        Name = "Котлеты",
                        ShortDescription = "Мясные",
                        LongDescription = "Котлеты мясные - 90 гр. 1шт. ",
                        Img = "/img/котлеты мясные.jpg",
                        Price = 8500,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Полуфабрикаты"]
                    },
                    new Food
                    {
                        Name = "Котлеты",
                        ShortDescription = "Куриные",
                        LongDescription = "Котлеты куриные - 90 гр. 1шт. ",
                        Img = "/img/котлеты куриные.jpg",
                        Price = 3600,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Полуфабрикаты"]
                    },
                    new Food
                    {
                        Name = "Котлеты",
                        ShortDescription = "Киевские",
                        LongDescription = "Котлеты киевские - 135 гр. 1шт. ",
                        Img = "/img/котлеты по киевски.jpg",
                        Price = 6500,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Полуфабрикаты"]
                    },
                    new Food
                    {
                        Name = "Манты",
                        ShortDescription = "Мясные",
                        LongDescription = "Манты мясные - 0,5кг. развесные. ",
                        Img = "/img/манты мясо и мясо с картошкой.jpg",
                        Price = 27000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Полуфабрикаты"]
                    },
                    new Food
                    {
                        Name = "Манты",
                        ShortDescription = "Мясные",
                        LongDescription = "Манты мясные - 1 кг. развесные",
                        Img = "/img/манты мясо и мясо с картошкой.jpg",
                        Price = 54000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Полуфабрикаты"]
                    },
                    new Food
                    {
                        Name = "Манты",
                        ShortDescription = "Картошка-мясо",
                        LongDescription = "Манты картошка-мясо - 0,5кг. развесные. ",
                        Img = "/img/манты мясо и мясо с картошкой.jpg",
                        Price = 22000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Полуфабрикаты"]
                    },
                    new Food
                    {
                        Name = "Манты",
                        ShortDescription = "Картошка-мясо",
                        LongDescription = "Манты картошка-мясо - 1кг. развесные. ",
                        Img = "/img/манты мясо и мясо с картошкой.jpg",
                        Price = 44000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Полуфабрикаты"]
                    },
                    new Food
                    {
                        Name = "Манты",
                        ShortDescription = "тыква",
                        LongDescription = "Манты тыква - 0,5кг. развесные. ",
                        Img = "/img/манты с тыквой.jpg",
                        Price = 17000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Полуфабрикаты"]
                    },
                    new Food
                    {
                        Name = "Манты",
                        ShortDescription = "Тыква",
                        LongDescription = "Манты тыква - 1кг. развесные. ",
                        Img = "/img/манты с тыквой.jpg",
                        Price = 34000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Полуфабрикаты"]
                    }


               );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Полуфабрикаты", Description = "Готовые полуфабрикаты, домашнего приготовления"},
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                        category.Add(element.categoryName, element);
                }
                return category;
            }
        }
    }
}
