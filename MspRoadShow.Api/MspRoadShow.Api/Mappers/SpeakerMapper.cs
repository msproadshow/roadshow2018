using MspRoadShow.Api.Business.Entities;
using MspRoadShow.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Mappers
{
    public static class SpeakerMapper
    {
        public static Speaker ToSpeaker(this SpeakerRequest src)
        {
            return new Speaker()
            {
                Id = Guid.NewGuid(),
                Name = src.SpeakerName,
                SpeakerBio = src.SpeakerBio,
                PhotoUrl = src.SpeakerPhotoUrl
            };
        }
    }
}
