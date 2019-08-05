using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VOLogistics.Models;

namespace VelconLogistics.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
        }


        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Load> Load { get; set; }

        public virtual ICollection<Driver> Driver { get; set; }



        [NotMappedAttribute]
        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

    }
}
