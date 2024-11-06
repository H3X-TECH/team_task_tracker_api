using AdministrationService.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.UnitTests
{
    public class UserRegistrationTests
    {
        private readonly IUserService _userService;
        public UserRegistrationTests(IUserService userService)
        {
            _userService = userService;
        }

        [Fact]
        public void CreateUser_WithValidInput_ReturnSuccess()
        {

        }
    }
}
