using Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IComplaintDAL : IRepository<Complaint>
    {
        public List<Complaint> GetComplaintsByCitizenID(int id);
    }
}
