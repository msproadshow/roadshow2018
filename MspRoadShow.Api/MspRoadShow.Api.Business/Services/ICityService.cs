using MspRoadShow.Api.Business.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Business.Services
{
    public interface ICityService
    {
        Task<Attendee> SelectWinnersInTheCityAsync(Guid cityId);
        Task<List<Attendee>> GetAttendeesForCityAsync(Guid cityId);
        Task<List<EvaluateQuestion>> GetEvalueteQuestionsForCityAsync(Guid cityId);
        Task ProcessEveluationAsync(Guid cityId, List<string> answers);
        Task<List<Sponsor>> GetSponsorsForCity(Guid cityId);
    }
}
