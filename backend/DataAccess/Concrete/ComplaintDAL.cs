using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class ComplaintDAL : EntityRepository<Complaint, SPCDBContext>, IComplaintDAL
    {
        public List<Complaint> GetComplaintsByCitizenID(int id)
        {
            using (var context = new SPCDBContext())
            {
                var result =
                    (from c in context.Complaints
                     where c.CitizenID == id
                     select new Complaint
                     {
                        AddressDescription = c.AddressDescription,
                        CitizenID = c.CitizenID,
                        City = c.City,
                        ComplaintDescription = c.ComplaintDescription,
                        ComplaintEndDate = c.ComplaintEndDate,
                        ComplaintID = c.ComplaintID,
                        ComplaintStartDate = c.ComplaintStartDate,
                        ComplaintStatusID = c.ComplaintStatusID,
                        ComplaintTypeID = c.ComplaintTypeID,
                        District = c.District,
                        Latitude = c.Latitude,
                        Longitude = c.Longitude,
                        NeighbourHood = c.NeighbourHood,
                        PhotoURL = c.PhotoURL,
                        PlatformID = c.PlatformID,
                        Street = c.Street,
                        Valid = c.Valid,
                        ValidatorStaffID = c.ValidatorStaffID,
                        ZIPCode = c.ZIPCode

                     }).ToList();
                return result;
            }
        }
    }
}
