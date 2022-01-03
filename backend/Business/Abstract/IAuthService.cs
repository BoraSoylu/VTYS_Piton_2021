using Business.Utilities;
using Business.Utilities.Results;
using Entities;
using System;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Token> CreateToken(Citizen citizen);
        IDataResult<Citizen> RegisterCitizen(CitizenRegisterDTO citizenRegister);
        IDataResult<Citizen> LoginCitizen(CitizenLoginDTO citizenLogin);
        IDataResult<Staff> RegisterStaff();
        IDataResult<Staff> LoginStaff();



    }
}
