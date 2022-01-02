using System;
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

        public IDataResult<Citizen> GetbyID(int id)
        {
            return new DataResults.SuccessfulDataResult<Citizen>(
                this.citizenDAL.Get(citizen => citizen.CitizenID == id));
        }
    }
}
