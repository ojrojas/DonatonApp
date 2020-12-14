using System;
using Core.Interfaces;

namespace Core.Entities
{
    public class DonationMoney: Donation, IAggregateRoot
    {
        public decimal Value { get; set; }
        public DateTime DateDonation { get; set; }
        public Bank Bank { get; set; }
        public Guid BankId { get; set; }
    }
}