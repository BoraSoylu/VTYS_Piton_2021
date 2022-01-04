using Business.Abstract;
using Business.Utilities;
using Business.Utilities.AuthorizationConstants;
using Business.Utilities.Hash;
using Business.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;

namespace Business.Conrete
{
    public class AuthenticationManager : IAuthService
    {
        private readonly ICitizenService citizenService;
        private readonly IStaffService staffService;
        private readonly TokenHandler tokenHandler;

        public AuthenticationManager(ICitizenService citizenService,
            IStaffService staffService, TokenHandler tokenHandler)
        {
            this.citizenService = citizenService;
            this.staffService = staffService;
            this.tokenHandler = tokenHandler;
        }

        public IDataResult<Token> CreateToken(Citizen citizen)
        {
            return new DataResults.SuccessfulDataResult<Token>(
                this.tokenHandler.CreateAccessToken(citizen), "Token başarıyla oluşturuldu.");
        }

        public IDataResult<Token> CreateToken(StaffAuthDTO staff)
        {
            return new DataResults.SuccessfulDataResult<Token>(
                this.tokenHandler.CreateAccessToken(staff.StaffID, staff.AuthorizationName));
        }

        public IDataResult<Citizen> RegisterCitizen(RegisterDTO citizenRegister)
        {
            //Validation işlemleri yapılacak.

            Citizen citizen = new Citizen
            {
                BirthDate = citizenRegister.BirthDate,
                Email = citizenRegister.Email,
                FirstName = citizenRegister.FirstName,
                LastName = citizenRegister.LastName,
                Gender = citizenRegister.Gender,
                PhoneNumber = citizenRegister.PhoneNumber,
                CreationDate = DateTime.Now
            };

            IDataResult<Citizen> result = this.citizenService.Add(citizen);
            int id = result.Data.CitizenID;

            byte[] passwordHash, passwordSalt;
            Encryption.CreatePasswordHash(citizenRegister.Password, out passwordHash, out passwordSalt);

            CitizenAuthentication citizenAuth = new CitizenAuthentication()
            {
                CitizenID = id,
                PasswordCreationDate = DateTime.Now,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            var result2 = this.citizenService.AddAuthentication(citizenAuth);
            //Burada citizenAuthentication tablosundaki citizen id'nin olup olmadığı kontrol edilebilir.

            if (result.Success)
                result.InfoMessage = Messages.CitizenRegisterSuccess;
            else
                result.InfoMessage = Messages.CitizenRegisterFail;

            return result;
        }
        public IDataResult<Staff> RegisterStaff(RegisterDTO newStaff)
        {

        }

        public IDataResult<Citizen> LoginCitizen(LoginDTO citizenLogin)
        {
            var citizenResult = citizenService.GetbyMail(citizenLogin.Email);
            if (!citizenResult.Success)
                return new DataResults.ErrorDataResult<Citizen>(citizenResult.InfoMessage);

            Citizen citizen = citizenResult.Data;
            IDataResult<CitizenAuthentication> authResult = citizenService.GetCitizenAuthbyID(citizen.CitizenID);
            //Burada citizenAuthentication tablosundaki citizen id'nin olup olmadığı kontrol edilebilir.
            
            CitizenAuthentication c_authentication = authResult.Data;
            bool verification = 
                Encryption.VerifyPasswordHash(citizenLogin.Password, c_authentication.PasswordHash, c_authentication.PasswordSalt);

            if (!verification)
                return new DataResults.ErrorDataResult<Citizen>(Messages.PasswordIncorrect);

            return new DataResults.SuccessfulDataResult<Citizen>(citizen, Messages.PasswordCorrect);
        }

        public IDataResult<StaffAuthDTO> LoginStaff(LoginDTO staffLogin)
        {
            var staffResult = this.staffService.GetAuthenticationbyEmail(staffLogin.Email);
            if (!staffResult.Success)
                return new DataResults.ErrorDataResult<StaffAuthDTO>(staffResult.InfoMessage);

            StaffAuthDTO staffAuth = staffResult.Data;

            bool verification = Encryption.VerifyPasswordHash(staffLogin.Password, staffAuth.PasswordHash, staffAuth.PasswordSalt);

            if (!verification)
                return new DataResults.ErrorDataResult<StaffAuthDTO>(Messages.PasswordIncorrect);

            return new DataResults.SuccessfulDataResult<StaffAuthDTO>(staffAuth, Messages.PasswordCorrect);
        }

    }
}
