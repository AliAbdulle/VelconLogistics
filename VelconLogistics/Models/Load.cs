using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VelconLogistics.Models;

namespace VOLogistics.Models
{
    public class Load
    {

        public int LoadId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public DateTime PickupDate { get; set; }
        [Required]
        public DateTime DeliverdDate { get; set; }
        [Required]
        public string Location { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public bool IsDeliverd { get; set; }

        public Load()
            
        {
            IsDeliverd = true;
        }


        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


    }
}
