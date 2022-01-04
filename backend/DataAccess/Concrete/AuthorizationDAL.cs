using System;

namespace DataAccess
{
    public class AuthorizationDAL : EntityRepository<Entities.Authorization, SPCDBContext>,
        IAuthorizationDAL
    {

    }
}
