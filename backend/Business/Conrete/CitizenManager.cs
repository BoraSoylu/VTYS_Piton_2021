using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Utilities.Results;
using DataAccess;
using Entities;

namespace Business.Conrete
{
    public class CitizenManager : ICitizenService
    {
        private readonly ICitizenDAL citizenDAL;

        public CitizenManager(ICitizenDAL citizenDAL)
        {
            this.citizenDAL = citizenDAL;
        }

        public IDataResult<List<Citizen>> GetAll()
        {
            return new DataResults.SuccessfulDataResult<List<Citizen>>(
                this.citizenDAL.GetAll(null));
        }

        public IDataResult<Citizen> GetbyID(int id)
        {
            return new DataResults.SuccessfulDataResult<Citizen>(
                this.citizenDAL.Get(citizen => citizen.CitizenID == id));
        }

        
    }
}
