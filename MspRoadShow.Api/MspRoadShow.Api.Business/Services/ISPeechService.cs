using MspRoadShow.Api.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Business.Services
{
    public interface ISpeechService
    {
        Task<Speaker> GetSpeakerBySpeechAsync(Guid speechId);
        Task SubscribeUserToSpeechAsync(Guid speechId, Guid userId);
        Task EvaluateSpeech(Guid speechId, Guid attendeeId, string comment = null, float? raiting = null);

    }
}
