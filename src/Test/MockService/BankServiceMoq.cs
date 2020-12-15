using Api.Controllers;
using Core.Entities;
using Core.Interfaces;
using Core.Services;
using FluentAssertions;
using Moq;
using System;
using System.Threading.Tasks;
using Test.MockRepository;
using Xunit;

namespace Test.MockService
{
    public class BankServiceMoq
    {
        private readonly BanksController _banksController;

        public BankServiceMoq()
        {
            Mock<IBankService> _bankRepository = new BankRepositoryMoq()._bankRepository;
            _banksController = new BanksController(_bankRepository.Object);
        }

        [Fact]
        public async Task TestMethoEditAsync()
        {
            var result = await _banksController.UpdateBank(new Bank
            {
                Id = Guid.NewGuid(),
                ModifiedBy= Guid.NewGuid(),
                ModifiedOn=  DateTime.Now,
                Description="Banco de occidente",
                State= true
            });

            result.Should().Be(default(Bank));
        }


        [Fact]
        public async Task TestMethoCreateAsync()
        {
            var result = await _banksController.CreateBank(new Bank
            {
                Id = Guid.NewGuid(),
                CreatedBy = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                Description="Av Villas",
                State = true
            });

            result.Should().Be(default(Bank));
        }

        [Fact]
        public async Task TestMethoDeleteAsync()
        {
            var result = await _banksController.DeleteBank(Guid.NewGuid());

            result.Should().Be(default(Bank));
        }
    }
}
