using Api.Controllers;
using Core.Entities;
using Core.Interfaces;
using FluentAssertions;
using Moq;
using System;
using System.Threading.Tasks;
using Test.MockRepository;
using Xunit;

namespace Test.MockService
{
    public class DonationPerishableServiceMoq
    {
        private readonly DonationPerishablesController _donationPerishableController;
        public DonationPerishableServiceMoq()
        {
            Mock<IDonationPerishableService> _donationService = new DonationPerishableRepositoryMoq()._donationPerishableRepository;
            _donationPerishableController = new DonationPerishablesController(_donationService.Object);
        }

        [Fact]
        public async Task TestMethoEditAsync()
        {
            var result = await _donationPerishableController.UpdateDonationPerishable(new DonationPerishable
            {
                Id = Guid.NewGuid(),
                ModifiedBy = Guid.NewGuid(),
                ModifiedOn = DateTime.Now,
                Address="Carrera 87 98 21",
                City="Bogota", 
                ContactNumber="3120032000",
                DateExpiration=DateTime.Now,
                DeliveryName="Josefina",
                Identification="1233554455",
                TypeIdentificationId=Guid.NewGuid(),
                Quantity=1200,
                Description="Prueba",
                Donor="Sergio",
                UnitMeasurement="Kilo",
                State=true,
                DeliveryTime= DateTime.Now
            });

            result.Should().Be(default(DonationPerishable));
        }


        [Fact]
        public async Task TestMethoCreateAsync()
        {
            var result = await _donationPerishableController.CreateDonationPerishable(new DonationPerishable
            {
               
                CreatedBy = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                Address="Carrera 87 98 21",
                City="Bogota", 
                ContactNumber="3120032000",
                DateExpiration=DateTime.Now,
                DeliveryName="Josefina",
                Identification="1233554455",
                TypeIdentificationId=Guid.NewGuid(),
                Quantity=1200,
                Description="Prueba",
                Donor="Sergio",
                UnitMeasurement="Kilo",
                State=true,
                DeliveryTime= DateTime.Now
            });

            result.Should().Be(default(DonationPerishable));
        }

        [Fact]
        public async Task TestMethoDeleteAsync()
        {
            var result = await _donationPerishableController.DeleteDonationPerishable(Guid.NewGuid());
            result.Should().Be(default(DonationPerishable));
        }

    }
}
