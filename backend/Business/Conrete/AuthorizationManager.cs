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
    public class AuthorizationManager : IAuthorizationService
    {
        private readonly IAuthorizationDAL authDal;
        public AuthorizationManager(IAuthorizationDAL authDal)
        {
            this.authDal = authDal;
        }

        public IDataResult<Authorization> Add(AuthorizationDTO newAuthorization)
        {
            Authorization authorization = new Authorization
            {
                AuthorizationName = newAuthorization.AuthorizationName,
                Authorizations = newAuthorization.Authorizations
            };
            Authorization auth = this.authDal.Insert(authorization);

            if (auth == null)
                return new DataResults.ErrorDataResult<Authorization>(Messages.AuthorizationAddFail);
            else
                return new DataResults.SuccessfulDataResult<Authorization>(
                    auth, Messages.AuthorizationAddSuccess);
        }

        public IDataResult<List<Authorization>> GetAll()
        {
            return new DataResults.SuccessfulDataResult<List<Authorization>>(
                this.authDal.GetAll(null), Messages.AuthorizationGetSuccess);
        }

        public IDataResult<string[]> GetAllAuthTypes()
        {
            return new DataResults.SuccessfulDataResult<string[]>(
                Authorizations.GetAuthorizations(), Messages.AuthorizationGetSuccess);
        }

        public IDataResult<Authorization> GetbyID(int id)
        {
            Authorization auth = this.authDal.Get(auth => auth.AuthorizationID == id);
            if (auth == null)
                return new DataResults.ErrorDataResult<Authorization>(Messages.AuthorizationGetFail);
            else
                return new DataResults.SuccessfulDataResult<Authorization>(auth, Messages.AuthorizationGetSuccess);
        }
    }
}
