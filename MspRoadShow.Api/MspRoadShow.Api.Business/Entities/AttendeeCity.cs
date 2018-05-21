using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Business.Entities
{
    public class AttendeeCity
    {
        public Guid Id { get; set; }
        public Guid CityId { get; set; }
        public Guid AttendeesId { get; set; }
        public Attendee Attendee { get; set; }
        public City City { get; set; }
    }
}
