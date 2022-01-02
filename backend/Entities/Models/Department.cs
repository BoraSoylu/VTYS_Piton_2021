using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Department : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }
        [ForeignKey("Department")]
        public int ManagerID { get; set; }
        [Required]
        [StringLength(20)]
        public string DepartmentName { get; set; }
    }
}
