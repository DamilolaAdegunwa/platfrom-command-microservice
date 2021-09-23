using AutoMapper;
using CRMService.Dtos;
using CRMService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMService.Profiles
{
    public class CRMsProfile : Profile
    {
        public CRMsProfile()
        {
            //Source --> Target
            CreateMap<CRM, CRMReadDto>();
            CreateMap<CRMCreateDto, CRM>();
        }
    }
}
