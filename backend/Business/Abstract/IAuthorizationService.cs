using Business.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAuthorizationService
    {
        IDataResult<Entities.Authorization> GetbyID(int id);
        IDataResult<List<Entities.Authorization>> GetAll();
        IDataResult<Entities.Authorization> Add(AuthorizationDTO newAuthorization);

        IDataResult<string[]> GetAllAuthTypes();
    }
}
