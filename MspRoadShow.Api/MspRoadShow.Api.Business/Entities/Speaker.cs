using System;
using System.Collections.Generic;

namespace MspRoadShow.Api.Business.Entities
{
    public class Speaker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SpeakerBio { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Note { get; set; }
        public List <Speech> SpeechList { get; set; }

        public Speaker()
        {
            SpeechList = new List<Speech>();
        }
    }
}
