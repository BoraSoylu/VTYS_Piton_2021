using Entities;
using Entities.DTOs;
using System;

namespace DataAccess
{
    public interface IStaffDAL : IRepository<Staff>
    {
        StaffAuthDTO GetAuthenticationbyEmail(string email);
    }
}
