using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(new Car {Id = 6,BrandId= 2, ColorId=1, ModelYear = "Ferrari",UnitPrice=650000 });
            carManager.Add(new Car { Id = 7, BrandId = 1, ColorId = 2, ModelYear = "BMW", UnitPrice = 750000 });
            carManager.Delete(new Car { Id = 6 });
            carManager.Update(new Car { Id = 4, ModelYear = "Tesla" });
            

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("Model: {0} Fiyat {1}",item.ModelYear, item.UnitPrice);
                
            }
            foreach (var item2 in carManager.GetById(1))
            {
                Console.WriteLine(item2.ModelYear);
            }
        }
    }
}
