using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Assigment : IEntity
    {
        [ForeignKey("Staff")]
        public int AssigneeID { get; set; }
        [ForeignKey("Staff")]
        public int AssignerID { get; set; }
        [ForeignKey("Complaint")]
        public int ComplaintID { get; set; }
        [ForeignKey("AssigmentStatus")]
        public int AssigmentStatusID { get; set; }
        [Required]
        public DateTime AssigmentStartDate { get; set; }
        [Required]
        public DateTime AssigmentEndDate { get; set; }
    }
}
