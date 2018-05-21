using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Business.Entities
{
    public class City
    {
        public class Location
        {
            public const string Paris = "Thread A";
            public const string Berlin = "Thread B";
            public const string London = "Thread C";
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public List<CitySponsor> SponsorList { get; set; }
        public List<Speech> Speeches { get; set; }
        public List<AttendeeCity> Attendees { get; set; }
        public List<EvaluateQuestion> EvaluateQuestions { get; set; }

        public City()
        {
            SponsorList = new List<CitySponsor>();
            Speeches = new List<Speech>();
            Attendees = new List<AttendeeCity>();
        }
    }
}
