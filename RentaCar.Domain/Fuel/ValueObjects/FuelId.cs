using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.Fuel.ValueObjects
{
    public sealed class FuelId : ValueObject
    {
        public Guid Value { get; private set; }
        public FuelId(Guid value)
        {
            Value = value;
        }

        public static FuelId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponent()
        {
            yield return Value;

        }
    }
}
