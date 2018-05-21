using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Models
{
    public class SpeechRequest
    {
        [Required]
        public Guid CityId { get; set; }
        [Required]
        public DateTimeOffset StartTime { get; set; }
        [Required]
        public DateTimeOffset EndTime { get; set; }
        [Required]
        [StringLength(15)]
        public string Location { get; set; }
        [Required]
        public Guid SpeakerId { get; set; }
        [Required]
        public string SpeechName { get; set; }
        [Required]
        public string SpeechDescription { get; set; }
    }
}
