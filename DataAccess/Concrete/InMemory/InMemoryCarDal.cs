using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=100,ModelYear="2020",Description="Porshe Panamera"},
                new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=90,ModelYear="2017",Description="Mercedes-Benz CLK200"},
                new Car{CarId=2,BrandId=3,ColorId=3,DailyPrice=80,ModelYear="2017",Description="BMW 330d"},
                new Car{CarId=2,BrandId=4,ColorId=4,DailyPrice=70,ModelYear="2017",Description="AUDI A3"},
                new Car{CarId=2,BrandId=5,ColorId=5,DailyPrice=50,ModelYear="2017",Description="Fiat Linea"}
                

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
          Car  carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.BrandId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUptade.CarId = car.CarId;
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.Description = car.Description;
        }
    }
}
