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
        private readonly IStaffAuthenticationDAL staffAuthDAL;

        public StaffManager(IStaffDAL staffDAL, IStaffAuthenticationDAL staffAuthDal)
        {
            this.staffDAL = staffDAL;
            this.staffAuthDAL = staffAuthDal;
        }

        public IDataResult<Staff> Add(Staff staff, StaffAuthentication staffAuth)
        {
            Staff st = this.staffDAL.Insert(staff);
            staffAuth.StaffID = st.StaffID;
            this.staffAuthDAL.Insert(staffAuth);

            return new DataResults.SuccessfulDataResult<Staff>(staff, Messages.StaffRegisterSuccess);
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
