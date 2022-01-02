using Business.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStaffService
    {
        IDataResult<Staff> GetbyID(int id);
        IDataResult<List<Staff>> GetAll();


    }
}
