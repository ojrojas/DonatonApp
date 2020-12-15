using Core.Entities;
using Core.Interfaces;
using Moq;
using System;
using System.Collections.Generic;

namespace Test.MockRepository
{
    public class BankRepositoryMoq
    {
        public Mock<IBankService> _bankRepository;

        public BankRepositoryMoq()
        {
            _bankRepository = new Mock<IBankService>();
            ConfiguracionBankRepositoryMoq();
        }

        private void ConfiguracionBankRepositoryMoq()
        {
            //Update
            _bankRepository.Setup((x) => x.Update(
                It.IsAny<Bank>())).ReturnsAsync(default(Bank));
            //Create
            _bankRepository.Setup((x) => x.Create(
                It.IsAny<Bank>())).ReturnsAsync(default(Bank));
            //Delete
            _bankRepository.Setup((x) => x.Delete(
                It.IsAny<Guid>())).ReturnsAsync(default(Bank));
            //Get
            _bankRepository.Setup((x) => x.GetAll()).ReturnsAsync(default(List<Bank>));
        }
    }
}
