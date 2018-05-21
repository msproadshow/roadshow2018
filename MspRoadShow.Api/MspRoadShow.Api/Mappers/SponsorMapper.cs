using MspRoadShow.Api.Business.Entities;
using MspRoadShow.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Mappers
{
    public static class SponsorMapper
    {
        public static Sponsor ToSponsor(this SponsorRequest src)
        {
            var sponsor = new Sponsor()
            {
                Id = Guid.NewGuid(),
                IsActiveSponsor = true,
                LogoUrl = src.LogoUrl,
                Name = src.Name,
                
            };

            src.CityesId.ForEach(
                i => sponsor.CitiesList
                .Add(new CitySponsor()
                {
                    SponsorId = sponsor.Id,
                    CityId = i
                }));
            return sponsor;
        }
    }
}
