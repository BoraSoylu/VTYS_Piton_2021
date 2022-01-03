using System;

namespace Entities.DTOs
{
    public class ComplaintCreateDTO : IDTO
    {
        public int ComplaintTypeID { get; set; }
        public string ComplaintDescription { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string NeighbourHood { get; set; }
        public string AddressDescription { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public string ZipCode { get; set; }
    }
}
