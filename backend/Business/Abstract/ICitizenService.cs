using System;
using System.Collections.Generic;
using Business.Utilities.Results;
using Entities;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICitizenService
    {
        IDataResult<Citizen> GetbyID(int id);
        IDataResult<List<Citizen>> GetAll();
        IDataResult<Citizen> GetbyMail(string email);
        IDataResult<CitizenAuthentication> GetCitizenAuthbyID(int id);

        IDataResult<Citizen> Add(Citizen citizen);
        IDataResult<CitizenAuthentication> AddAuthentication(CitizenAuthentication citizenAuth);

        IDataResult<Complaint> CreateComplaint(ComplaintCreateDTO complaint, int id);
    }
}
