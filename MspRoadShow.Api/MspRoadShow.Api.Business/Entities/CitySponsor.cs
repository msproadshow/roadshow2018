using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Business.Entities
{
    public class CitySponsor
    {
        public Guid CityId { get; set; }
        public Guid SponsorId { get; set; }
        public City City { get; set; }
        public Sponsor Sponsor { get; set; }
    }
}
