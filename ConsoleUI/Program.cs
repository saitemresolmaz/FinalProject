using Business.Concrete;
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

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2)) //2 numaralı kategorideki ürünler
            {
                Console.WriteLine(product.ProductName);
            }

            foreach (var product2 in productManager.GetByUnitPrice(40, 100)) //fiyatı 40 ile 100 arasında olanlar
            {
                Console.WriteLine(product2.UnitPrice + " " + product2.ProductName);
            }
        }
    }
}

