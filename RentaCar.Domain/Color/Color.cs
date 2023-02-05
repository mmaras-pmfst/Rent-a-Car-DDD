using RentaCar.Domain.Color.ValueObjects;
using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.Color
{
    public sealed class Color : AggregateRoot<ColorId>
    {
        public string Name { get; }
        public Color(ColorId colorId, string name)
            :base(colorId)
        {
            Name = name;
        }

        public static Color Create(string name)
        {
            return new(ColorId.CreateUnique(), name);
        }
    }
}
