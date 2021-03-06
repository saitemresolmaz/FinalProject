﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    // SOLID
    // O > Open Closed Principle 
    // Yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiçbir koduna dokunamazsın.
    class Program
    {
        static void Main(string[] args)
        {
            //DTO > Data Transformation Object
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            //foreach (var product in productManager.GetAllByCategoryId(2)) //2 numaralı kategorideki ürünler
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //foreach (var product2 in productManager.GetByUnitPrice(40, 100)) //fiyatı 40 ile 100 arasında olanlar
            //{
            //    Console.WriteLine(product2.UnitPrice + " " + product2.ProductName);
            //}

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data) //2 numaralı kategorideki ürünler
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}

