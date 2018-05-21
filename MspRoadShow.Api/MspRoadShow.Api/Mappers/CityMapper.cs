using MspRoadShow.Api.Business.Entities;
using MspRoadShow.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Mappers
{
    public static class CityMapper
    {
        public static City ToCity(this CityRequest src)
        {
            return new City()
            {
                Id = Guid.NewGuid(),
                Name = src.CityName,
                Place = src.Place,
                StartDate = src.StartDate,
                EndDate = src.EndDate
            };
        }
    }
}
