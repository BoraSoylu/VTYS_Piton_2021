using Business.Abstract;
using Business.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;

namespace Business.Conrete
{
    public class StaffManager : IStaffService
    {
        public IDataResult<List<Staff>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Staff> GetbyID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
