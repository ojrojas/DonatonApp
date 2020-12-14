using System;
using Core.Interfaces;

namespace Core.Entities
{
    public class DonationNonPerishableAndPerishable: Donation, IAggregateRoot
    {
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string DeliveryName { get; set; }
        public string ContactNumber { get; set; }
    }
}