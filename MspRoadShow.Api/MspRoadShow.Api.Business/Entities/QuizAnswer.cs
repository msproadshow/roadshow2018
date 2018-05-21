using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Business.Entities
{
    public class QuizAnswer
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public QuizQuestion Question { get; set; }

    }
}
