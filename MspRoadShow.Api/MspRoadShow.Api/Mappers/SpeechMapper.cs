using MspRoadShow.Api.Business.Entities;
using MspRoadShow.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Mappers
{
    public static class SpeechMapper
    {
        public static Speech ToSpeech(this SpeechRequest src)
        {
            return new Speech()
            {
                Id = Guid.NewGuid(),
                CityId = src.CityId,
                Location = src.Location,
                Description = src.SpeechDescription,
                StartTime = src.StartTime,
                EndTime = src.EndTime,
                IsActive = true,
                SpeakerId = src.SpeakerId,
                Name = src.SpeechName,
            };
        }
    }
}
