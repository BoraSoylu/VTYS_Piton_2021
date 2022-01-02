using System;
using System.Collections.Generic;
using Business.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface ICitizenService
    {
        IDataResult<Citizen> GetbyID(int id);
        IDataResult<List<Citizen>> GetAll();


    }
}
