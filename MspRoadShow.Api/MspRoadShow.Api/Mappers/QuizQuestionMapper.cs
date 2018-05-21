using MspRoadShow.Api.Business.Entities;
using MspRoadShow.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Mappers
{
    public static class QuizQuestionMapper
    {
        public static QuizQuestion ToQuizzQustion (this QuizQuestionRequest src)
        {
            return new QuizQuestion()
            {
                Id = Guid.NewGuid(),
                IsMultipleChoiseActive = src.IsMultipleChoiseActive,
                Title = src.Title,
                SpeechId = src.SpeechId
            };
        }
    }
}
