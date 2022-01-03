using Business.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IComplaintTypeService
    {
        IDataResult<List<ComplaintType>> GetAllComplaintTypes();
        IDataResult<ComplaintType> GetComplaintTypebyID(int id);
        IDataResult<ComplaintType> AddComplaintType(string complaintTypeName);
    }
}
