using System;
using Core.Interfaces;

namespace Core.Entities
{
    public class Donation : BaseEntity, IAggregateRoot
    {
        public TypeDonation TypeDonation { get; set; }
        public Guid TypeDonationId { get; set; }
        public TypeIdentification TypeIdentification { get; set; }
        public Guid TypeIdentificationId { get; set; }
        public string Identification { get; set; }
        public string Donor { get; set; }
    }
}