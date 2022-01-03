using Business.Abstract;
using Business.Utilities.AuthorizationConstants;
using Business.Utilities.Results;
using DataAccess;
using Entities;
using Entities.DTOs;
using System;

namespace Business.Conrete
{
    public class ComplaintManager : IComplaintService
    {
        private readonly IComplaintDAL complaintDAL;
        public ComplaintManager(IComplaintDAL complaintDAL)
        {
            this.complaintDAL = complaintDAL;
        }

        public IDataResult<Complaint> CreateComplaint(ComplaintCreateDTO complaint, int id)
        {
            throw new NotImplementedException();
        }
    }
}
