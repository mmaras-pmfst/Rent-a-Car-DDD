using RentaCar.Domain.Car.Entities;
using RentaCar.Domain.Car.ValueObjects;
using RentaCar.Domain.Color.ValueObjects;
using RentaCar.Domain.Common.Models;
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

        

        public string Name { get; }
        public string RegistrationPlate { get; }
        public decimal Kilometers { get; }
        public string Image { get; }
        public string Status { get; } //ENUM
        public decimal PricePerDay { get; }
        public string FuelType { get; } //ENUM
        public ColorId ColorId { get; }
        public OfficeId OfficeId { get; }
        public IReadOnlyCollection<Reservation> Reservations => _reservations;

        public Car(CarId id) : base(id)
        {
        }
    }
}
