using Entities;
using System;

namespace DataAccess
{
    public class ComplaintDAL : EntityRepository<Complaint, SPCDBContext>, IComplaintDAL
    {

    }
}
