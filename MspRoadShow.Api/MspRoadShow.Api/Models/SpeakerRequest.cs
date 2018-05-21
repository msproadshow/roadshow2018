using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Models
{
    public class SpeakerRequest
    {
        [Required]
        [StringLength(50)]
        public string SpeakerName { get; set; }
        [Required]
        public string SpeakerBio { get; set; }
        [Required]
        public string SpeakerPhotoUrl { get; set; }
        public decimal UserRating { get; set; }
    }
}
