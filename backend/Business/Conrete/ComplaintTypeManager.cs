using Business.Abstract;
using Business.Utilities.AuthorizationConstants;
using Business.Utilities.Results;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Conrete
{
    public class ComplaintTypeManager : IComplaintTypeService
    {
        private readonly IComplaintTypeDAL complaintTypeDAL;
        public ComplaintTypeManager(IComplaintTypeDAL complaintTypeDAL)
        {
            this.complaintTypeDAL = complaintTypeDAL;
        }
        public IDataResult<ComplaintType> AddComplaintType(string complaintTypeName)
        {
            ComplaintType ct = new ComplaintType();
            ct.TypeName = complaintTypeName;

            return new DataResults.SuccessfulDataResult<ComplaintType>(
                this.complaintTypeDAL.Insert(ct), Messages.ComplaintTypeCreated);
        }

        public IDataResult<List<ComplaintType>> GetAllComplaintTypes()
        {
            return new DataResults.SuccessfulDataResult<List<ComplaintType>>(
                this.complaintTypeDAL.GetAll(null), Messages.ComplaintTypesGet);
        }

        public IDataResult<ComplaintType> GetComplaintTypebyID(int id)
        {
            return new DataResults.SuccessfulDataResult<ComplaintType>(
                this.complaintTypeDAL.Get(complaintType => complaintType.TypeID == id), Messages.ComplaintTypesGet);
        }
    }
}
