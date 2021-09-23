using AutoMapper;
using AssetService.Dtos;
using AssetService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetService.Profiles
{
    public class AssetsProfile : Profile
    {
        public AssetsProfile()
        {
            //Source --> Target
            CreateMap<Asset, AssetReadDto>();
            CreateMap<AssetCreateDto, Asset>();
        }
    }
}
