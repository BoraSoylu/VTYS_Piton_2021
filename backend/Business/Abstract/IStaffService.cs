using Business.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStaffService
    {
        IDataResult<Staff> GetbyID(int id);
        IDataResult<List<Staff>> GetAll();
        IDataResult<StaffAuthDTO> GetAuthenticationbyEmail(string email);
        IDataResult<Staff> Add(Staff staff, StaffAuthentication staffAuth);
    }
}
