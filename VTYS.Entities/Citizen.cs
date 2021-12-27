using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VTYS.Entities
{
    public class Citizen
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CitizenID { get; set; }
        
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }




    }
}
