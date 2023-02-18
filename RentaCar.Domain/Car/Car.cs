using RentaCar.Domain.Car.Entities;
using RentaCar.Domain.Car.ValueObjects;
using RentaCar.Domain.CarBrand.ValueObjects;
using RentaCar.Domain.Color.ValueObjects;
using RentaCar.Domain.Common.Models;
using RentaCar.Domain.Enums;
using RentaCar.Domain.Office.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.Car
{
    public sealed class Car : AggregateRoot<CarId>
    {
        private readonly List<Reservation> _reservations = new List<Reservation>();

        public string Name { get; private set; }
        public string RegistrationPlate { get; private set; }
        public decimal Kilometers { get; private set; }
        public string Image { get; private set; }
        public CarStatus Status { get; private set; }
        public decimal PricePerDay { get; private set; }
        public FuelType FuelType { get; private set; }
        public ColorId ColorId { get; private set; }
        public OfficeId OfficeId { get; private set; }
        public CarModelId CarModelId { get; private set; }
        public IReadOnlyCollection<Reservation> Reservations => _reservations;

        public Car(
            CarId carId,
            string name,
            string registrationPlate,
            decimal kilometers,
            string image,
            CarStatus status,
            decimal pricePerDay,
            FuelType fuelType,
            ColorId colorId,
            OfficeId officeId,
            CarModelId carModelId)
            : base(carId)
        {
            Name = name;
            RegistrationPlate = registrationPlate;
            Kilometers = kilometers;
            Image = image;
            Status = status;
            PricePerDay = pricePerDay;
            FuelType = fuelType;
            ColorId = colorId;
            OfficeId = officeId;
            CarModelId = carModelId;
        }



    }
}
