using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripManagment.Data.Models
{
    public class Trip
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Trip Name must be less then 100 characters")]
        public string TripName { get; set; }
        [StringLength(255, ErrorMessage = "Trip Description must be less then 255 characters")]
        public string TripDescription { get; set; }
        [Required]
        public DateTime DateStarted { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
