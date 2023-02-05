using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.CarBrand.ValueObjects
{
    public sealed class CarBrandId : ValueObject
    {
        public Guid Value { get; }
        public CarBrandId(Guid value)
        {
            Value = value;
        }

        public static CarBrandId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponent()
        {
            yield return Value;

        }
    }
}
