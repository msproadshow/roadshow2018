using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Business.Entities
{
    public class SpeechAttendee
    {
        public Guid Id { get; set; }
        public Guid SpeechId { get; set; }
        public Guid AttendeeId { get; set; }
        public string Comment { get; set; }
        public decimal? Rating { get; set; }
        public Attendee Attendee { get; set; }
        public Speech Speech { get; set; }
    }
}
