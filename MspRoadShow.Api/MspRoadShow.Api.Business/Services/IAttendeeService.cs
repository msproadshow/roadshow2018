using MspRoadShow.Api.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Business.Services
{
    public interface IAttendeeService
    {
        Task<string> RegisterAttendeeAsync(Attendee attendee);
        Task CheckInAttendeeAsync(Guid attendeesId);
        Task SubscribeAttendeeToSpeechAsync(Guid attendeeId, Guid speechId);
        Task AddScoreToAttendeeAync(Guid attendeeId, int score);
        Task<IList<QuizQuestion>> GetQuizzQuestionsForAttendeeAsync(Guid attendeeId);
        Task<IList<Speech>> GetSpeechesForAttendeeAsync(Guid attendeeId);
        Task<IList<EvaluateQuestion>> GetEvaluateQuestions(Guid cityId);
    }
}