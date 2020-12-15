using System;
using Ardalis.Specification;
using Core.Entities;

namespace Core.Specifications
{
    public class DonationNonPerishableSpecification : Specification<DonationNonPerishable>
    {
        public DonationNonPerishableSpecification(Guid TypeIdentificationId, string Identification)
        {
            Query.Where(i => i.TypeIdentificationId == TypeIdentificationId && i.Identification == Identification);
        }
    }
}