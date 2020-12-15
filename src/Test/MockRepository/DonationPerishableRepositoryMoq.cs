using Core.Entities;
using Core.Interfaces;
using Moq;
using System;
using System.Collections.Generic;

namespace Test.MockRepository
{
    public class DonationPerishableRepositoryMoq
    {
        public Mock<IDonationPerishableService> _donationPerishableRepository;

        public DonationPerishableRepositoryMoq()
        {
            _donationPerishableRepository = new Mock<IDonationPerishableService>();
            ConfiguracionDonationPerishableRepositoryMoq();
        }

        private void ConfiguracionDonationPerishableRepositoryMoq()
        {
            //Update
            _donationPerishableRepository.Setup((x) => x.Update(
                It.IsAny<DonationPerishable>())).ReturnsAsync(default(DonationPerishable));
            //Create
            _donationPerishableRepository.Setup((x) => x.Create(
                It.IsAny<DonationPerishable>())).ReturnsAsync(default(DonationPerishable));
            //Delete
            _donationPerishableRepository.Setup((x) => x.Delete(
                It.IsAny<Guid>())).ReturnsAsync(default(DonationPerishable));
            //Get
            _donationPerishableRepository.Setup((x) => x.GetAll()).ReturnsAsync(default(List<DonationPerishable>));
        }
    }
}
