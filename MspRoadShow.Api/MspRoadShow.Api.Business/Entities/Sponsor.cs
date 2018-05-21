using System;
using System.Collections.Generic;
using System.Text;

namespace MspRoadShow.Api.Business.Entities
{
    public class Sponsor
    {
        public static class SponsorsLevels
        {
            public static string Platunim = "Platinum";
            public static string Gold = "Gold";
            public static string Silver = "Silver";
            public static string Bronze = "Bronze";
            public static string Friend = "Friend";
            public static string Info = "Info";
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string SponsorLevel { get; set; }
        public bool IsActiveSponsor { get; set; }
        public List<CitySponsor> CitiesList { get; set; }

        public Sponsor()
        {
            CitiesList = new List<CitySponsor>();
        }
    }
}
