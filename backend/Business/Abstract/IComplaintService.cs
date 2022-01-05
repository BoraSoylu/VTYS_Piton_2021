using Business.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IComplaintService
    {
        IDataResult<Complaint> CreateComplaint(ComplaintCreateDTO complaint, int id);

        IDataResult<List<Complaint>> GetAll();
        IDataResult<List<Complaint>> GetComplaintsByCitizenID(int id);


    }
}
