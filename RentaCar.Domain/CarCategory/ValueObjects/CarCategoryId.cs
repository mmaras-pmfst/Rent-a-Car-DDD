using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.CarCategory.ValueObjects
{
    public sealed class CarCategoryId : ValueObject
    {
        public Guid Value { get; private set; }
        public CarCategoryId(Guid value)
        {
            Value = value;
        }

        public static CarCategoryId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponent()
        {
            yield return Value;

        }
    }
}
