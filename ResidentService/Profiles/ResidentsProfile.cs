using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResidentService.Dtos;
using ResidentService.Models;

namespace ResidentService.Profiles
{
    public class ResidentsProfile : Profile
    {
        public ResidentsProfile()
        {
            CreateMap<ResidentCreateDto, Resident>();
            CreateMap<Resident, ResidentReadDto>();
        }
    }
}
