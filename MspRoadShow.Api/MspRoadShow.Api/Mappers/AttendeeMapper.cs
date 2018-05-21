using MspRoadShow.Api.Business.Entities;
using MspRoadShow.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Mappers
{
    public static class AttendeeMapper
    {
        public static Attendee ToAttendee(this AttendeesRequest src)
        {
            return new Attendee()
            {
                Id = Guid.NewGuid(),
                Email = src.Email,
                FirstName = src.FirstName,
                LastName = src.LastName,
                Company = src.Company,
                Position = src.Position,
                Activity = src.Activity,
                CreatedAt = DateTimeOffset.UtcNow
            };
        }
    }
}
