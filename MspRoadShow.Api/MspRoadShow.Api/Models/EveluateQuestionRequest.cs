using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Models
{
    public class EveluateQuestionRequest
    {
        public Guid CityId { get; set; }
        public Guid QuestionId { get; set; }
        public IList<string> Answers { get; set; }
    }
}
