using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationService.Application.Model
{
    public class AuthTokenResponse
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; } = "Bearer";
        public int ExpiresIn { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ExpiresAt { get; set; } = DateTime.Now.AddMinutes(60);
    }
}
