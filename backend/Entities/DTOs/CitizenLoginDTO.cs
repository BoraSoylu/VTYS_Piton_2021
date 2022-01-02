using System;

namespace Entities
{
    public class CitizenLoginDTO : IDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
