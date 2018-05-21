using System;
using System.Collections.Generic;

namespace MspRoadShow.Api.Dto.Models
{
    public class AttendeePersonalScheduleRequest
    {
        public Guid AttendeeId { get; set; }
        public IList<Guid> SpeechIdList { get; set; }
    }
}
