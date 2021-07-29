using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car 
                    {
                        name = "Tesla Model S", 
                        shortDesc = "Fast Car", 
                        longDesc = "A beautiful, fast and very quiet Tesla car", 
                        img = "/img/tesla.jpg", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
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
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Bold and stylish",
                        longDesc = "A convenient car for the city",
                        img = "/img/bmw-m3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
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
                        Category = _categoryCars.AllCategories.Last()
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
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes G class",
                        shortDesc = "Big SUV",
                        longDesc = "This car has 3 differential locks",
                        img = "/img/G_Class.jpg",
                        price = 50000,
                        isFavourite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Rolls Royce Cullinan",
                        shortDesc = "The Father of all cars",
                        longDesc = "Very solid and luxury",
                        img = "/img/RRCullinan.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Lamborghini aventador svj",
                        shortDesc = "Very fast car",
                        longDesc = "One of the fastest cars in the Nurburg ring",
                        img = "/img/Lamborghini.jpg",
                        price = 60000,
                        isFavourite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            } 
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
