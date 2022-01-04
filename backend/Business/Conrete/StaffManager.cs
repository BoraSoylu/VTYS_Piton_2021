using Business.Abstract;
using Business.Utilities.AuthorizationConstants;
using Business.Utilities.Results;
using DataAccess;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Conrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDAL staffDAL;

        public StaffManager(IStaffDAL staffDAL)
        {
            this.staffDAL = staffDAL;
        }

        public IDataResult<List<Staff>> GetAll()
        {
            var staffs = this.staffDAL.GetAll(null);

            if (staffs == null)
                return new DataResults.ErrorDataResult<List<Staff>>(Messages.StaffGetFail);
            else
                return new DataResults.SuccessfulDataResult<List<Staff>>(staffs, Messages.StaffGetSuccess);
        }

        public IDataResult<StaffAuthDTO> GetAuthenticationbyEmail(string email)
        {
            var auth = this.staffDAL.GetAuthenticationbyEmail(email);
            if (auth == null)
                return new DataResults.ErrorDataResult<StaffAuthDTO>(Messages.StaffAuthenticationCrash);
            else
                return new DataResults.SuccessfulDataResult<StaffAuthDTO>(auth, Messages.StaffAuthenticationSuccess);
        }

        public IDataResult<Staff> GetbyID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
