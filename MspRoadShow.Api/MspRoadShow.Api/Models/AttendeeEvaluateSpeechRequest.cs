using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Models
{
    public class AttendeeEvaluateSpeechRequest
    {
        public Guid AttendeeId { get; set; }
        public Guid SpeechId { get; set; }
        public string Comment { get; set; }
        public int? Rating { get; set; }
    }
}
