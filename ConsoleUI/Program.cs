using Business.Abstract;
using Business.Concrete;
using Core.Entities;
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
            // AddCarTest();


            //CarManager carManager = new CarManager(new EfCarDal(), new RuleManager());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName+"  "+car.DailyPrice);
            //}

            CarManager carManager = new CarManager(new EfCarDal(), new RuleManager());

            //carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 300, ModelYear = "2006", Description = "AUDI" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }





        }






        private static void AddCarTest()
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
