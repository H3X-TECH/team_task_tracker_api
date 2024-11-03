using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Domain.Entities
{
    public class UserVerification : BaseEntity
    {
        public string UserVerificationId { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpireAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
