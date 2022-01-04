using System;

namespace Entities.DTOs
{
    public class StaffAuthDTO : IDTO
    {
        public int StaffID { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int AuthorizationID { get; set; }
        public string AuthorizationName { get; set; }
    }
}
