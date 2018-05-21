using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Models
{
    public class AttendeeResult
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }
        public Guid City { get; set; }
        public IList<SpeechResult> Speeches { get; set; }
    }
}
