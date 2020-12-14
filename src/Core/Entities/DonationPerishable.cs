using System;
using Core.Interfaces;

namespace Core.Entities
{
    public class DonationPerishable : DonationNonPerishableAndPerishable, IAggregateRoot
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string UnitMeasurement { get; set; }
        public DateTime DateExpiration { get; set; }
    }
}