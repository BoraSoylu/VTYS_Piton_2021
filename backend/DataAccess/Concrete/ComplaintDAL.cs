using Entities;
using System;

namespace DataAccess.Concrete
{
    public class ComplaintDAL : EntityRepository<Complaint, SPCDBContext>, IComplaintDAL
    {

    }
}
