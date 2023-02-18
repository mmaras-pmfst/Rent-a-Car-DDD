using RentaCar.Domain.Common.Models;
using RentaCar.Domain.Fuel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.Fuel
{
    public sealed class Fuel : AggregateRoot<FuelId>
    {
        public string Name { get; private set; }

        public Fuel(FuelId fuelId,string name)
            : base(fuelId)
        {
            Name = name;
        }

        public static Fuel Create(string name)
        {
            return new(FuelId.CreateUnique(), name);
        }
    }
}
