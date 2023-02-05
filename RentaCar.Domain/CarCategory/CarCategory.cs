using RentaCar.Domain.CarCategory.ValueObjects;
using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.CarCategory
{
    public sealed class CarCategory : AggregateRoot<CarCategoryId>
    {
        public string Name { get; }
        public string Description { get; }
        public CarCategory(CarCategoryId carCategoryId, string name, string description)
            : base(carCategoryId)
        {
            Name = name;
            Description = description;
        }

        public static CarCategory Create(string name, string description)
        {
            return new(CarCategoryId.CreateUnique(), name, description);
        }
    }
}
