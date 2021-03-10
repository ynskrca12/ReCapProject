using Business.Abstract;
using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RuleManager : IRuleService<IEntity>
    {
        public void MinNameRule(IEntity entity)
        {
            var downCastedEntity = (Car)entity;

            if (downCastedEntity.Description.Length < 2)
            {
                throw new Exception("Araba ismi minimum iki karakter içermelidir");
            }
        }

        public void MinPriceRule(IEntity entity)
        {
            var downCastedEntity = (Car)entity;

            if (downCastedEntity.DailyPrice <= 0)
            {
                throw new Exception("Bir aracın günlük fiyatı sıfırdan büyük olmalıdır");
            }
        }
    }
}
