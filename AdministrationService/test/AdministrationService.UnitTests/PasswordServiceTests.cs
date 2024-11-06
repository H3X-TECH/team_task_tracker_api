using AdministrationService.Application.Util.Interfaces;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.UnitTests
{
    public class PasswordServiceTests
    {
        public readonly IPasswordService _passwordService;
        public PasswordServiceTests(IPasswordService passwordService)
        {
            _passwordService = passwordService;
        }

        [Fact]
        public void HashPassword_WithValidInput_ShouldReturnNonEmptyHash()
        {
            //Arrange
            string password = "Admin123!@#";

            //Act
            string hash = _passwordService.HashPassword(password);

            //Assert
            hash.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void HashPassword_WithSameTwoInput_ShouldProduceUniqueHashes()
        {
            //Arrange
            string password = "Admin123!@#";

            //Act
            string hash1 = _passwordService.HashPassword(password);
            string hash2 = _passwordService.HashPassword(password);

            //Assert
            hash1.Should().NotBe(hash2);

        }

        [Fact]
        public void VerifyPassword_WithCorrectPassword_ShouldReturnTrue()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void VerifyPassword_WithIncorrectPassword_ShouldReturnFalse()
        {

        }

        [Fact]
        public void VerifyPassword_WithNullPassword_ShouldReturnFalse()
        {

        }
    }
}
