using System;
using System.Collections.Generic;

namespace MspRoadShow.Api.Business.Entities
{
    public class Speech
    {
        
        public Guid Id { get; set; }
        public Guid CityId { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public Guid SpeakerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Speaker Speaker { get; set; }
        public List<SpeechAttendee> AttendeesList { get; set; }
        public List<QuizQuestion> Questions { get; set; }
        public bool IsActive { get; set; }

        public Speech()
        {
            AttendeesList = new List<SpeechAttendee>();
            Questions = new List<QuizQuestion>();
        }
    }
}
