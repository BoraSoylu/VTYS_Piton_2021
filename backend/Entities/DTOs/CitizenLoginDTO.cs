using System;

namespace Entities
{
    public class LoginDTO : IDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
