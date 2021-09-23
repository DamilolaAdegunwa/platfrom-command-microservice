using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocationService.Dtos;
using LocationService.Models;

namespace LocationService.Profiles
{
    public class LocationsProfile : Profile
    {
        public LocationsProfile()
        {
            CreateMap<LocationCreateDto, Location>();
            CreateMap<Location, LocationReadDto>();
        }
    }
}
