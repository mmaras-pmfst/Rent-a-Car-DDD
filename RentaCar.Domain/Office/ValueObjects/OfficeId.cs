using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.Office.ValueObjects
{
    public sealed class OfficeId : ValueObject
    {
        public Guid Value { get; }
        public OfficeId(Guid value)
        {
            Value = value;
        }

        public static OfficeId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponent()
        {
            yield return Value;

        }
    }
}
