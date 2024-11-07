using AdministrationService.Application.Util.Implementations;
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
        public readonly PasswordService _passwordService;
        public PasswordServiceTests()
        {
            _passwordService = new PasswordService();
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
            string password = "Admin123!@#";
            string hash = _passwordService.HashPassword(password);

            //Act
            bool isValid = _passwordService.VerifyPassword(password, hash);

            //Assert
            isValid.Should().BeTrue();

        }

        [Fact]
        public void VerifyPassword_WithIncorrectPassword_ShouldReturnFalse()
        {
            //Arrange
            string correctPassword = "Admin123!@#";
            string wrongPassword = "wrongPassword";
            string hash = _passwordService.HashPassword(correctPassword);

            //Act
            bool isValid = _passwordService.VerifyPassword(wrongPassword,hash);

            //Assert
            isValid.Should().BeFalse();
        }

        [Fact]
        public void VerifyPassword_WithNullPassword_ShouldReturnFalse()
        {
            //Arrange
            string password = "Admin123!@#";
            string hash = _passwordService.HashPassword(password);

            //Act
            bool isValid = _passwordService.VerifyPassword(null, hash);

            //Assert
            isValid.Should().BeFalse();
        }
    }
}
