using System;
using Entities;
using System.Linq;

namespace DataAccess
{
    public class CitizenDAL : EntityRepository<Citizen, SPCDBContext>, ICitizenDAL
    {
        
    }
}
