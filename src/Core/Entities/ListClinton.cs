using System;
using Core.Interfaces;

namespace Core.Entities
{
    public class ListClinton : BaseEntity,IAggregateRoot
    {
        public TypeIdentification TypeIdentification { get; set; }
        public Guid TypeIdentificationId { get; set; }
        public string Identification { get; set; }
    }
}