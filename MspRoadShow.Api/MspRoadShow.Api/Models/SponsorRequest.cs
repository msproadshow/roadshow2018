using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MspRoadShow.Api.Models
{
    public class SponsorRequest
    {
        [Required]
        [StringLength(15)]
        public string Name { get; set; }
        [Required]
        public string LogoUrl { get; set; }
        [Required]
        public List<Guid>CityesId { get; set; }
    }
}
