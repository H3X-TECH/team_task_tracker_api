using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Domain.Entities
{
    public class UserCredentials
    {
        public string UserId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime LastPasswordChangeDate { get; set; }
    }
}
