using RentaCar.Domain.CarBrand.ValueObjects;
using RentaCar.Domain.CarCategory.ValueObjects;
using RentaCar.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.CarBrand.Entities
{
    public sealed class CarModel : Entity<CarModelId>
    {
        public string Name { get; private set; }
        public CarBrandId CarBrandId { get; private set; }
        public CarCategoryId CarCategoryId { get; private set; }

        public CarModel(CarModelId id, string name, CarBrandId carBrandId, CarCategoryId carCategoryId) : base(id)
        {
            Name = name;
            CarBrandId = carBrandId;
            CarCategoryId = carCategoryId;
        }

        public static CarModel Create(string name, CarBrandId carBrandId, CarCategoryId carCategoryId)
        {
            return new(CarModelId.CreateUnique(), name, carBrandId, carCategoryId);
        }
    }
}
