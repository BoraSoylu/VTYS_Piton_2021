using Entities;
using Entities.DTOs;
using System;
using System.Linq;

namespace DataAccess
{
    public class StaffDAL : EntityRepository<Staff, SPCDBContext>, IStaffDAL
    {
        public StaffAuthDTO GetAuthenticationbyEmail(string email)
        {
            using (var context = new SPCDBContext())
            {
                var result =
                    (from s in context.Staffs
                     join sa in context.StaffAuthentications
                         on s.StaffID equals sa.StaffID
                     join sau in context.Authorizations
                        on s.AuthorizationID equals sau.AuthorizationID
                     where s.Email == email
                     select new StaffAuthDTO
                     {
                         AuthorizationID = s.AuthorizationID,
                         AuthorizationName = sau.AuthorizationName,
                         PasswordSalt = sa.PasswordSalt,
                         PasswordHash = sa.PasswordHash,
                         StaffID = s.StaffID
                     }).First();
                return result;
            }
        }
    }
}
