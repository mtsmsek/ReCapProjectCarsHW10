using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            CarTest();
            //ColorTest();
            
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());


            //colorManager.Add(new Color { ColorId = 1, ColorName = "Kırmızı" });
            //colorManager.Add(new Color { ColorId = 2, ColorName = "Mavi" });
            //colorManager.Add(new Color { ColorId = 3, ColorName = "Yeşil" });




            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { BrandId = 1, ColorId = 1, ModelYear = "Passat", UnitPrice = 200000, Description = "Marka Volkswagen, rengi kırmızı" });
            //carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = "Golf", UnitPrice = 130000, Description = "Marka Volksvagen, rengi mavi" });
            //carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = "Transporter", UnitPrice = 150000, Description = "Marka Volkswagen rengi mavi" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 3, ModelYear = "Captur", UnitPrice = 212500, Description = "Marka Renault rengi yeşil" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 3, ModelYear = "Symbol", UnitPrice = 141000, Description = "Marka Renault rengi yeşil" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 1, ModelYear = "Clio", UnitPrice = 180000, Description = "Renk : Kırmızı Marka: Renault" });
            //carManager.Delete(new Car { Id = 8 });
            

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Model: {0}\nMarka: {1}\nRenk: {2}\nFiyat: {3} ", car.ModelYear,car.BrandName,car.ColorName,car.UnitPrice);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 1, BrandName = "Volkswagen" });
            brandManager.Add(new Brand { BrandId = 2, BrandName = "Renault" });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
