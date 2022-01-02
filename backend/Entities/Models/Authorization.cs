using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Authorization : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorizationID { get; set; }
        [Required]
        [StringLength(30)]
        public string AuthorizationName { get; set; }
        [Required]
        public bool[] Authorizations { get; set; }
    }
}
