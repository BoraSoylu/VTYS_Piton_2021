using Business.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;

namespace Business.Abstract
{
    public interface IComplaintService
    {
        IDataResult<Complaint> CreateComplaint(ComplaintCreateDTO complaint, int id);
    }
}
