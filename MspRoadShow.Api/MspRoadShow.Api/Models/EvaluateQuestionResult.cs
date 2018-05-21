using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Models
{
    public class EvaluateQuestionResult
    {
        public Guid QuestionId { get; set; }
        public Guid CityId { get; set; }
        public string Text { get; set; }
        public bool IsMultipleChoisePossible { get; set; }
        IList<string> Answers { get; set; }
    }
}
