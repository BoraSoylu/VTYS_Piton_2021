using Business.Utilities;
using Business.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Token> CreateToken(Citizen citizen);
        IDataResult<Token> CreateToken(StaffAuthDTO staff);
        IDataResult<Citizen> RegisterCitizen(RegisterDTO citizenRegister);
        IDataResult<Citizen> LoginCitizen(LoginDTO citizenLogin);
        IDataResult<Staff> RegisterStaff(StaffRegisterDTO newStaff);
        IDataResult<StaffAuthDTO> LoginStaff(LoginDTO staffLogin);



    }
}
