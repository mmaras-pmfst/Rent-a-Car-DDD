using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.CarBrand.ValueObjects
{
    public sealed class CarModelId : ValueObject
    {
        public Guid Value { get; }
        public CarModelId(Guid value)
        {
            Value = value;
        }

        public static CarModelId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponent()
        {
            yield return Value;

        }
    }
}
