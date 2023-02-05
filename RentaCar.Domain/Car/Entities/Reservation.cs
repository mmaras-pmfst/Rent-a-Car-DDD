using RentaCar.Domain.Car.ValueObjects;
using RentaCar.Domain.Common.Models;
using RentaCar.Domain.Office.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.Car.Entities
{
    public sealed class Reservation : Entity<ReservationId>
    {
        public OfficeId PickUpLocationId { get; }
        public OfficeId DropDownLocationId { get; }
        public CarId CarId { get; }
        public Guid UserId { get; } //PROMJENITI USER MODEL DA BUDE AGGREGATE
        public DateTime PickUpDateTime { get; }
        public DateTime DropDownDateTime { get; }
        public decimal TotalPrice { get; }

        public Reservation(ReservationId id, OfficeId pickUpLocationId, OfficeId dropDownLocationId, CarId carId, Guid userId, DateTime pickUpDateTime, DateTime dropDownDateTime, decimal totalPrice) 
            : base(id)
        {
            PickUpLocationId = pickUpLocationId;
            DropDownLocationId = dropDownLocationId;
            CarId = carId;
            UserId = userId;
            PickUpDateTime = pickUpDateTime;
            DropDownDateTime = dropDownDateTime;
            TotalPrice = totalPrice;
        }

        public static Reservation Create(OfficeId pickUpLocationId, OfficeId dropDownLocationId, CarId carId, Guid userId, DateTime pickUpDateTime, DateTime dropDownDateTime, decimal totalPrice)
        {
            return new(ReservationId.CreateUnique(), pickUpLocationId, dropDownLocationId, carId, userId, pickUpDateTime, dropDownDateTime, totalPrice);
        }

    }
}
