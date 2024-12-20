using System.Collections.Generic;

namespace UpRaise.DTOs
{
    public class UserSecurityDTO
    {
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> ExternalLogins { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool HasAuthenticator { get; set; }
        public bool TwoFactorClientRemembered { get; set; }
        public int RecoveryCodesLeft { get; set; }
    }
}