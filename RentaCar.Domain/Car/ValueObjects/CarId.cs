using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.Car.ValueObjects
{
    public sealed class CarId : ValueObject
    {
        public Guid Value { get; private set; }
        public CarId(Guid value)
        {
            Value = value;
        }

        public static CarId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponent()
        {
            yield return Value;

        }
    }
}
