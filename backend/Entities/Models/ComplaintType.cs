using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ComplaintType : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeID { get; set; }
        [Required]
        [StringLength(20)]
        public string TypeName { get; set; }
    }
}
