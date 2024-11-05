using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Domain.Entities
{
    public class UserInfo : BaseEntity
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string IsEmailVerified { get; set; }
        public DateTime CreatedDate { get; set; } //Base Entity
        public DateTime UpdatedDate { get; set; }

        //Navigate property for related UserCredentials 
        public UserCredential UserCredentials { get; set; }
    }
}
