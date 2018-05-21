using System;
using System.Collections.Generic;

namespace MspRoadShow.Api.Business.Entities
{
    public class Attendee
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Activity { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public int Score { get; set; }
        public bool IsAttendeePresented { get; set; }
        public List<SpeechAttendee> SpeechesList { get; set; }
        public AttendeeCity City { get; set; }

        public Attendee()
        {
            SpeechesList = new List<SpeechAttendee>();
        }
    }
}
