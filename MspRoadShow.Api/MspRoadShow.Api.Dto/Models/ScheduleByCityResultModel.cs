using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Dto.Models
{
    public class SpeechResultModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SpeakerId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    public class ScheduleByLocation
    {
        public string Location { get; set; }
        public SpeechResultModel Schedule { get; set; }
    }
}
