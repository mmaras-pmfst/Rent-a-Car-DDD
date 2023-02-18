using RentaCar.Domain.CarBrand.Entities;
using RentaCar.Domain.CarBrand.ValueObjects;
using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.CarBrand
{
    public sealed class CarBrand : AggregateRoot<CarBrandId>
    {
        private readonly List<CarModel> _carModels = new List<CarModel>();
        public string? Name { get; private set; }
        public IReadOnlyCollection<CarModel> CarModels => _carModels;
        public CarBrand(CarBrandId id, string? name) 
            : base(id)
        {
            Name = name;
        }

        public static CarBrand Create(string name)
        {
            return new(CarBrandId.CreateUnique(), name);
        }
    }
}
