using System;
using Ardalis.Specification;
using Core.Entities;

namespace Core.Specifications
{
    public class DonationPerishableSpecification : Specification<DonationPerishable>
    {
        public DonationPerishableSpecification(Guid TypeIdentificationId, string Identification)
        {
            Query.Where(i => i.TypeIdentificationId == TypeIdentificationId && i.Identification == Identification);
        }
    }
}