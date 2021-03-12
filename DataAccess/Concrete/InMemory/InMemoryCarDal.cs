using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear="Passat",UnitPrice = 200000,Description="Marka Volkswagen, rengi kırmızı"},
                new Car{Id=2, BrandId=1, ColorId=2, ModelYear="Golf",UnitPrice = 130000,Description="Marka Volksvagen, rengi mavi"},
                new Car{Id=3, BrandId=1, ColorId=2, ModelYear="Transporter",UnitPrice = 150000,Description="Marka Volkswagen rengi mavi"},
                new Car{Id=4, BrandId=2, ColorId=3, ModelYear="Captur",UnitPrice = 212500,Description="Marka Renault rengi yeşil"},
                new Car{Id=5, BrandId=2, ColorId=3, ModelYear="Symbol",UnitPrice = 141000,Description="Marka Renault rengi yeşil"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p =>p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.BrandId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.UnitPrice = car.UnitPrice;



        }
    }
}
