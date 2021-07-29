using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {        
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Fast Car",
                        longDesc = "A beautiful, fast and very quiet Tesla car",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electro car"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Quiet and peaceful",
                        longDesc = "A convenient car for the city",
                        img = "/img/ford_fiesta.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Classic car"]
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Bold and stylish",
                        longDesc = "A convenient car for the city",
                        img = "/img/bmw-m3.jpg",
                        price = 40000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Classic car"]
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Elegant and comfortable",
                        longDesc = "A convenient car for the city",
                        img = "/img/mercedes-benz-c-class-amg.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Classic car"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Compact",
                        longDesc = "Ideal for a big city",
                        img = "/img/nissan_leaf.jpg",
                        price = 15000,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Electro car"]
                    },
                    new Car
                    {
                        name = "Mercedes G class",
                        shortDesc = "Big SUV",
                        longDesc = "This car has 3 differential locks",
                        img = "/img/G_Class.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Classic car"]
                    },
                    new Car
                    {
                        name = "Rolls Royce Cullinan",
                        shortDesc = "The Father of all cars",
                        longDesc = "Very solid and luxury",
                        img = "/img/RRCullinan.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Classic car"]
                    },
                    new Car
                    {
                        name = "Lamborghini aventador svj",
                        shortDesc = "Very fast car",
                        longDesc = "One of the fastest cars in the Nurburg ring",
                        img = "/img/Lamborghini.jpg",
                        price = 61000,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Classic car"]
                    });
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null) // We check whether the variable contains
                { // if == null create new category in DB
                    var list = new Category[]
                    {
                        new Category { categoryName ="Electro car", desc = "Modern mode of transport"},
                        new Category { categoryName ="Classic car", desc = "Cars with an engine"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
