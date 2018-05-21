using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Models
{
    public class AttendeeRequest
    {
        public string Email { get; set; }
        public string Activity { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public Guid CityID { get; set; }

    }
}
