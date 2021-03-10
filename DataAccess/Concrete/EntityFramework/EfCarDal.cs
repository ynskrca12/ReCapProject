﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 //CarId = c.CarId,
                                 //Description = c.Description,
                                 //ColorId=c.ColorId,
                                 //BrandId=c.BrandId,
                                 //DailyPrice=c.DailyPrice,
                                 //ModelYear=c.ModelYear

                                 CarName = c.Description,
                                 DailyPrice=c.DailyPrice,
                                 

                             };
                return result.ToList();

            }
        }
    }
}
