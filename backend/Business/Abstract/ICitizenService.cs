using System;
using Business.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface ICitizenService
    {
        IDataResult<Citizen> GetbyID(int id);



    }
}
