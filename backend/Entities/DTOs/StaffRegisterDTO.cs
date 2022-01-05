using System;

namespace Entities.DTOs
{
    public class StaffRegisterDTO : IDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public int AuthorizationID { get; set; }
    }
}
