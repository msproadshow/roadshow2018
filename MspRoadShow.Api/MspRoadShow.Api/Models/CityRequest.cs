using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Models
{
    public class CityRequest
    {
        [Required]
        [StringLength(20)]
        public string CityName { get; set; }

        [Required]
        [StringLength(50)]
        public string Place { get; set; }

        [Required]
        public DateTimeOffset StartDate { get; set; }

        [Required]
        public DateTimeOffset EndDate { get; set; }
    }
}
