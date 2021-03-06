using Business.Abstract;
using Core.Entities;
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
        ICarDal _carDal;
        IRuleService<IEntity> _rules;
       
        public CarManager(ICarDal carDal, IRuleService<IEntity> ruleService)
        {
            _carDal = carDal;
            _rules = ruleService;

        }


        public void Add(Car entity)
        {
            _rules.MinNameRule(entity);
            _rules.MinPriceRule(entity);
            _carDal.Add(entity);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
