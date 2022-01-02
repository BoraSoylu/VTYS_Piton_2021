using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Platform : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlatformID { get; set; }
        [Required]
        [StringLength(1000)]
        public string PlatformData { get; set; }
    }
}
