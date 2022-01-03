using Entities;
using System;

namespace DataAccess
{
    public class ComplaintTypeDAL : EntityRepository<ComplaintType, SPCDBContext>, IComplaintTypeDAL
    {

    }
}
