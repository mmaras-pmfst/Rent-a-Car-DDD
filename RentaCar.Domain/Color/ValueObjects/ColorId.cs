using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.Color.ValueObjects
{
    public sealed class ColorId : ValueObject
    {
        public Guid Value { get; private set; }
        public ColorId(Guid value)
        {
            Value = value;
        }

        public static ColorId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public static ColorId Create(Guid value)
        {
            return new ColorId(value);
        }

        public override IEnumerable<object> GetEqualityComponent()
        {
            yield return Value;

        }
    }
}
