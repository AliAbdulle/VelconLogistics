using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VelconLogistics.Models;

namespace VOLogistics.Models
{
    public class Driver
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Work { get; set; }
       
        [NotMapped]
        [Display(Name = "FullName")]
        public string FullName => $"{FirstName} {LastName}";

  
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}
