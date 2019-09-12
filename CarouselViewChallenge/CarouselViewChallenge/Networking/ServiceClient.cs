using System;
using System.Collections.Generic;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.Networking
{
    public class ServiceClient
    {
        private static ServiceClient _ServiceClientInstance;

        public static ServiceClient ServiceClientInstance
        {
            get
            {
                if (_ServiceClientInstance == null)
                    _ServiceClientInstance = new ServiceClient();
                return _ServiceClientInstance;
            }
        }
        public List<ConsultancyModel> GetConsultancyInformationPosts()
        {
            return new List<ConsultancyModel>
            {
                new ConsultancyModel { Title = "Turtle Bay Resort", Date = "JULY 24, 2015",  Image = "hawaii.jpg" },
                new ConsultancyModel { Title = "Grand Hotel", Date = "JULY 24, 2015", Image = "michigan.jpg" },
                new ConsultancyModel { Title = "Vista Verde", Date = "JULY 23, 2015", Image = "Colorado.jpg" },
                new ConsultancyModel { Title = "Woodloch Pines", Date = "JULY 23, 2015", Image = "hawaii.jpg" },
            };
        }
    }
}
