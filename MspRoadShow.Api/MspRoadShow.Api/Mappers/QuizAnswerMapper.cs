using MspRoadShow.Api.Business.Entities;
using MspRoadShow.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Mappers
{
    public static class QuizzAnswerMapper
    {
        public static QuizAnswer ToQuizAnswer(this QuizAnswerRequest src)
        {
            return new QuizAnswer()
            {
                Id = Guid.NewGuid(),
                IsCorrect = src.IsCorrect,
                QuestionId = src.QuestionId,
                Text = src.Text
            };
        }
    }
}
