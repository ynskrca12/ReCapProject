using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRuleService<T> where T : class
    {
        void MinNameRule(T entity);
        void MinPriceRule(T entity);
    }
}
