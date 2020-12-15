using System;
using Ardalis.Specification;
using Core.Entities;

namespace Core.Specifications
{
    public class DonationMoneySpecification : Specification<DonationMoney>
    {
        public DonationMoneySpecification(Guid TypeIdentificationId, string Identification)
        {
            Query.Where(i => i.TypeIdentificationId == TypeIdentificationId && i.Identification == Identification);
        }
    }
}