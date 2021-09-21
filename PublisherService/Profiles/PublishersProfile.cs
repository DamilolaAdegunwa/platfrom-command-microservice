using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublisherService.Dtos;
using PublisherService.Models;
namespace PublisherService.Profiles
{
    public class PublishersProfile : Profile
    {
        public PublishersProfile()
        {
            CreateMap<PublisherRequest, Publisher>();
            CreateMap<Publisher, PublisherResponse>();
        }
    }
}
