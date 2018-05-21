using System;

namespace MspRoadShow.Api.Business.Entities
{
    public class EvaluateQuestion
    {
        public Guid Id { get; set; }
        public Guid CityId { get; set; }
        public string Text { get; set; }
        public string Answers { get; set; }
        public bool IsMultipleChoisePossible { get; set; }
        public City City { get; set; }
    }
}
