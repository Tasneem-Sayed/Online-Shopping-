using EShopFashion.Models;

using EShopFashion.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopFashion.Services
{
    public class ArrivalsAreaServices : IArrivalsAreaServices
    {
        public List<SingleArrivalsArea> GetArrivalsAreas()
        {
            List<SingleArrivalsArea> products = new List<SingleArrivalsArea>();
            products.Add(new SingleArrivalsArea()
                {

                    Id = 1,
                    Name = " Jeans midi cocktail dress",
                    ImageURL = "~/../img/product-img/product-1.jpg",
                    price = 39.90


                });
            products.Add(new SingleArrivalsArea()
            {

                Id = 2,
                Name = " Jeans midi cocktail dress",
                ImageURL = "~/../img/product-img/product-2.jpg",
                price = 35.90


            });
            products.Add(new SingleArrivalsArea()
            {

                Id = 3,
                Name = " Jeans midi cocktail dress",
                ImageURL = "~/../img/product-img/product-3.jpg",
                price = 40


            });
            products.Add(new SingleArrivalsArea()
            {

                Id = 4,
                Name = " Jeans midi cocktail dress",
                ImageURL = "~/../img/product-img/product-4.jpg",
                price = 39.90


            });
            products.Add(new SingleArrivalsArea()
            {

                Id = 5,
                Name = " Jeans midi cocktail dress",
                ImageURL = "~/../img/product-img/product-5.jpg",
                price = 39.10


            });
            products.Add(new SingleArrivalsArea()
            {

                Id = 6,
                Name = " Jeans midi cocktail dress",
                ImageURL = "~/../img/product-img/product-6.jpg",
                price = 45.50


            });
            products.Add(new SingleArrivalsArea()
            {

                Id = 7,
                Name = " Jeans midi cocktail dress",
                ImageURL = "~/../img/product-img/product-7.jpg",
                price = 50.68


            });
            products.Add(new SingleArrivalsArea()
            {

                Id = 8,
                Name = " Jeans midi cocktail dress",
                ImageURL = "~/../img/product-img/product-8.jpg",
                price = 50.68


            });
            products.Add(new SingleArrivalsArea()
            {

                Id = 8,
                Name = " Jeans midi cocktail dress",
                ImageURL = "~/../img/product-img/product-9.jpg",
                price = 50.68


            });

            return (products);
        }
    }
}
