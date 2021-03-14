using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;

        public CarManager(ICarDal icarDal)
        {
            _icarDal = icarDal;
        }

        public void Add(Car car)
        {
            if (car.ModelYear.Length>2 && car.UnitPrice>0)
            {
                _icarDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araba adı 2 harften uzun değil ya da günlük fiyat 0'dan küçük)");
            }
            
        }


        public void Delete(Car car)
        {
            _icarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _icarDal.GetAll();
        }


        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _icarDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _icarDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _icarDal.Update(car);
        }
    }
}
