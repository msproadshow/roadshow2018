using System;
using System.Collections.Generic;

namespace MspRoadShow.Api.Models
{
    public class AttendeeQuizResult
    {
        public Guid QuizQuestionId { get; set; }
        public bool IsMultipleChoiseActive { get; set; }
        public string Title { get; set; }
        public string SpeechName { get; set; }
        IList<AttendeeQuizAnswerResult> Answers { get; set; }
    }

    public class AttendeeQuizAnswerResult
    {
        public Guid AnswerId { get; set; }
        public string AsnwerText { get; set; }
    }
}
