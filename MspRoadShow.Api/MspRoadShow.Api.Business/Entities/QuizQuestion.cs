using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Business.Entities
{
    public class QuizQuestion
    {
        public Guid Id { get; set; }
        public Guid SpeechId { get; set; }
        public string Title { get; set; }
        public List<QuizAnswer> Answers { get; set; }
        public bool IsMultipleChoiseActive { get; set; }
        public Speech Speech { get; set; }

        public QuizQuestion()
        {
            Answers = new List<QuizAnswer>();
        }
    }
}
