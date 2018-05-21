using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Models
{
    public class SpeechResult
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SpeakerId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    public class ScheduleByLocationResult
    {
        public string Location { get; set; }
        public SpeechResult Schedule { get; set; }
    }
}
