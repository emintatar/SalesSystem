using Business.Abstract;
using Business.Adapters;
using Business.Concrete;
using Business.Services.FakeBankService;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new FbService());
            productService.Sell(
              new Product { ProductId = 1, ProductName = "Laptop", ProductPrice = 50 },
              new Student() { Id = 1, FirstName = "Emin", LastName = "Tatar" }
            );
        }
    }
}