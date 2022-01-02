using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Complaint : IEntity
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComplaintID { get; set; }
        [Required]
        [ForeignKey("Citizen")]
        public int CitizenID { get; set; }
        [Required]
        [ForeignKey("ComplaintStatus")]
        public int ComplaintStatusID { get; set; }
        [Required]
        [ForeignKey("ComplaintType")]
        public int ComplaintTypeID { get; set; }
        [Required]
        [ForeignKey("Platform")]
        public int PlatformID { get; set; }
        [Required]
        public DateTime ComplaintStartDate { get; set; }
        [Required]
        public DateTime ComplaintEndDate { get; set; }
        [Required]
        [StringLength(4000)]
        public string ComplaintDescription { get; set; }
        [Required]
        [StringLength(30)]
        public string City { get; set; }
        [Required]
        [StringLength(30)]
        public string District { get; set; }
        [Required]
        [StringLength(50)]
        public string NeighbourHood { get; set; }
        [Required]
        [StringLength(50)]
        public string Street { get; set; }
        [StringLength(200)]
        public string AddressDescription { get; set; }
        [Required]
        //[RegularExpression(@"^\d+(\.\d{1,6})?$")]
        //[Range(0, 999.999999)]
        public decimal Longitude { get; set; }
        //[RegularExpression(@"^\d+(\.\d{1,6})?$")]
        //[Range(0, 99.999999)]
        public decimal Latitude { get; set; }
        [Required]
        [StringLength(255)]
        public string PhotoURL { get; set; }
        public bool Valid { get; set; }
        public string ZIPCode { get; set; }
        [ForeignKey("Staffs")]
        public int ValidatorStaffID { get; set; }
    }
}
