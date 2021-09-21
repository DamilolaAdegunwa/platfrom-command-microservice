using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublisherService.Dtos
{
    public class PublisherRequest
    {
        public string Name { get; set; }

        public string Founder { get; set; }

        public string YearFounded { get; set; }

        public string HeadquarterLocation { get; set; }
    }
}
