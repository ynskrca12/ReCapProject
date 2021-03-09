using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            IRuleService<IEntity> rulesService = new RuleManager();
            

            Car car1 = new Car
            {
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 100,
                ModelYear = "2017",
                Description = "Tesla"
            };
            
            ICarService carManager = new CarManager(new EfCarDal(), new RuleManager());

            carManager.Add(car1);
            
            foreach (var car in carManager.GetAll())
            {
               
                Console.WriteLine(car.Description);
            }

        }
    }
}
