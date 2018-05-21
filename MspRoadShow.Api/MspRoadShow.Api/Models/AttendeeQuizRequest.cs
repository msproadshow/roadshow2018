using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Models
{
    public class AttendeeQuizRequest
    {
        public Guid QuestionId { get; set; }
        public IList<Guid> AnswerId { get; set; }
        public Guid UserId { get; set; }
    }
}
