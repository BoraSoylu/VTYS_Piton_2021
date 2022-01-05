using Business.Abstract;
using Business.Utilities.AuthorizationConstants;
using Business.Utilities.Results;
using DataAccess;
using Entities;
using Entities.DTOs;
using System;

namespace Business.Conrete
{
    public class ComplaintManager : IComplaintService
    {
        private readonly IComplaintDAL complaintDAL;
        public ComplaintManager(IComplaintDAL complaintDAL)
        {
            this.complaintDAL = complaintDAL;
        }

        public IDataResult<Complaint> CreateComplaint(ComplaintCreateDTO complaint, int id)
        {
            Complaint comp = new Complaint
            {
                AddressDescription = complaint.AddressDescription,
                CitizenID = id,
                City = complaint.City,
                ComplaintDescription = complaint.ComplaintDescription,
                ComplaintEndDate = DateTime.Now,
                ComplaintStartDate = DateTime.Now,
                ComplaintStatusID = 1,
                ComplaintTypeID = complaint.ComplaintTypeID,
                District = complaint.District,
                Latitude = complaint.Latitude,
                Longitude = complaint.Longitude,
                NeighbourHood = complaint.NeighbourHood,
                PhotoURL = "No photo path",
                PlatformID = 1,
                Street = complaint.Street,
                ZIPCode = complaint.ZipCode,
                ValidatorStaffID = 1,
                Valid = false,
            };

            Complaint compla = this.complaintDAL.Insert(comp);
            if (compla == null)
                return new DataResults.ErrorDataResult<Complaint>("İhbar başarısız.");
            else
                return new DataResults.SuccessfulDataResult<Complaint>(compla, "İhbar başarılı.");
        }
    }
}
