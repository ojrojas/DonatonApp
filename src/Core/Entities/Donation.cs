using System;
using Core.Interfaces;

namespace Core.Entities
{
    public class Donation : BaseEntity, IAggregateRoot
    {
        public TypeIdentification TypeIdentification { get; set; }
        public Guid TypeIdentificationId { get; set; }
        public string Identification { get; set; }
        public string Donor { get; set; }
    }
}