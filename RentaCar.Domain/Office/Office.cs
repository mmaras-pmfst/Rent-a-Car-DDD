using RentaCar.Domain.Common.Models;
using RentaCar.Domain.Office.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Domain.Office
{
    public sealed class Office : AggregateRoot<OfficeId>
    {
        public string City { get; }
        public string StreetName { get; }
        public string StreetNumber { get; }
        public string Country { get; }
        public DateTime OpeningTime { get; }
        public DateTime ClosingTime { get; }
        public string PhoneNumber { get; }

        public Office(OfficeId officeId, string city, string streetName, string streetNumber, string country, DateTime openingTime, DateTime closingTime, string phoneNumber)
            : base(officeId)
        {
            City = city;
            StreetName = streetName;
            StreetNumber = streetNumber;
            Country = country;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
            PhoneNumber = phoneNumber;
        }

        public static Office Create(string city, string streetName, string streetNumber, string country, DateTime openingTime, DateTime closingTime, string phoneNumber)
        {
            return new(OfficeId.CreateUnique(), city, streetName, streetNumber, country, openingTime, closingTime, phoneNumber);
        }
        
    }
}
