using System;
using Core.Interfaces;

namespace Core.Entities
{
    public class DonationNonPerishable: DonationNonPerishableAndPerishable, IAggregateRoot
    {
        public string Description { get; set; }
        public double Weight { get; set; }
        public StateMaterial StateMaterial { get; set; }
        public Guid StateMaterialId { get; set; }
    }
}