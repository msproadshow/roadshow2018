using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MspRoadShow.Api.Models;

namespace MspRoadShow.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Client")]
    public class ClientController : Controller
    {
        [HttpGet]
        [Route("/schedule-by-city/{cityId}")]
        public async Task<IActionResult> ScheduleByCity(Guid cityId)
        {
            var res = new ScheduleByLocationResult();
            return Json(res);
        }

        [HttpGet]
        [Route("/sponsors-by-city/{cityId}")]
        public async Task<IActionResult> SponsorsByCity(Guid cityId)
        {
            var res = new SponsorsResult();
            return Json(res);
        }

        [HttpGet]
        [Route("/speakers-by-city/{cityId}")]
        public async Task<IActionResult> SpeakersByCity(Guid cityId)
        {
            var res = new List<SpeakerResult>();
            return Json(res);
        }

        [HttpGet]
        [Route("/speaker-by-speakerid/{speakerId}")]
        public async Task<IActionResult> SpeakerBySpeakerId(Guid speakerId)
        {
            var res = new SpeakerResult();
            return Json(res);
        }

        [HttpPost]
        [Route("/register-attendee")]
        public async Task<IActionResult> RegisterAttendee([FromBody]AttendeeRequest attendeeRequest)
        {
            return Ok();
        }

        //TODO: Authentification?
        [HttpGet]
        [Route("/attendee-by-attendeeid/{attendeeId}")]
        public async Task<IActionResult> AttendeeByAttendeeId(Guid attendeeId)
        {
            var res = new AttendeeResult();
            return Json(res);
        }

        [HttpPost]
        [Route("/save-personal-schedule")]
        public async Task<IActionResult> SavePersonalSchedule([FromBody]AttendeePersonalScheduleRequest personalScheduleRequest)
        {
            return Ok();
        }

        [HttpPost]
        [Route("/evaluate-speech")]
        public async Task<IActionResult> EvaluateSpeech([FromBody]AttendeeEvaluateSpeechRequest evaluateSpeechRequest)
        {
            return Ok();
        }

        [HttpGet]
        [Route("/quiz-by-attendeeid/{attendeeId}")]
        public async Task<IActionResult> QuizByAttendeeId(Guid attendeeId)
        {
            var res = new List<AttendeeQuizAnswerResult>();
            return Json(res);
        }

        [HttpPost]
        [Route("/attendee-quiz-responses")]
        public async Task<IActionResult> AttendeeQuizResponses([FromBody]IList<AttendeeQuizRequest> evaluateSpeechRequest)
        {
            return Ok();
        }
    }
}