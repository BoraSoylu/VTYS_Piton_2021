using System;
using System.Collections.Generic;
using System.Security.Claims;
using Business.Abstract;
using Business.Utilities.AuthorizationConstants;
using Business.Utilities.Results;
using DataAccess;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Conrete
{
    public class CitizenManager : ICitizenService
    {
        private readonly ICitizenDAL citizenDAL;
        private readonly ICitizenAuthDAL citizenAuthDAL;
        private readonly IComplaintService complaintService;
        private readonly IHttpContextAccessor httpContextAccessor;

        public CitizenManager(ICitizenDAL citizenDAL, ICitizenAuthDAL citizenAuthDAL,
            IComplaintService complaintService, IHttpContextAccessor httpAccessor)
        {
            this.citizenDAL = citizenDAL;
            this.citizenAuthDAL = citizenAuthDAL;
            this.complaintService = complaintService;
            this.httpContextAccessor = httpAccessor;
        }

        public IDataResult<Citizen> Add(Citizen citizen)
        {
            var newCitizen = this.citizenDAL.Insert(citizen);
            return new DataResults.SuccessfulDataResult<Citizen>(newCitizen);
        }

        public IDataResult<CitizenAuthentication> AddAuthentication(CitizenAuthentication citizenAuth)
        {
            var newCitizenAuth = this.citizenAuthDAL.Insert(citizenAuth);
            return new DataResults.SuccessfulDataResult<CitizenAuthentication>(newCitizenAuth);
        }

        public IDataResult<Complaint> CreateComplaint(ComplaintCreateDTO complaint, int id)
        {
            
            return this.complaintService.CreateComplaint(complaint, id);
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

        public IDataResult<Citizen> GetbyMail(string email)
        {
            Citizen citizen = this.citizenDAL.Get(citizen => citizen.Email == email);

            if (citizen == null)
                return new DataResults.ErrorDataResult<Citizen>(Messages.NotFoundCitizen);
            else
                return new DataResults.SuccessfulDataResult<Citizen>(citizen, Messages.FoundCitizen);
        }

        public IDataResult<CitizenAuthentication> GetCitizenAuthbyID(int id)
        {
            return new DataResults.SuccessfulDataResult<CitizenAuthentication>(
                this.citizenAuthDAL.Get(citizen => citizen.CitizenID == id));
        }
    }
}
