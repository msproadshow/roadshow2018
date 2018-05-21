using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Models
{
    public class QuizAnswerRequest
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public bool IsCorrect { get; set; }
        [Required]
        public Guid QuestionId { get; set; }
    }
}
