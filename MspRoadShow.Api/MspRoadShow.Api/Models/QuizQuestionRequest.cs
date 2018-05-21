using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Models
{
    public class QuizQuestionRequest
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public bool IsMultipleChoiseActive { get; set; }
        [Required]
        public Guid SpeechId { get; set; }
    }
}
