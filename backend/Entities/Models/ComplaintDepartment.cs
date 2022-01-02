using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ComplaintDepartment : IEntity
    {
        
        [ForeignKey("Complaint")]
        public int ComplaintID { get; set; }
        
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
    }
}
