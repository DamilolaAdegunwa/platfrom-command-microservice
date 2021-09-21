using Microsoft.AspNetCore.Mvc;
using PublisherService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublisherService.Models;
using PublisherService.Dtos;
using AutoMapper;

namespace PublisherService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublishersController : Controller
    {
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;
        private readonly IBaseRepository _baseRepository;

        public PublishersController(IPublisherRepository publisherRepository, IMapper mapper, IBaseRepository baseRepository)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
            _baseRepository = baseRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PublisherResponse>>> GetPublishers()
        {
            return Ok(await _publisherRepository.GetPublishers());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PublisherResponse>> GetPublisher(int id)
        {
            var p = _publisherRepository.GetPublisher(id);
            if(p != null)
            {
                return Ok(p);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<PublisherResponse>> CreatePublisher(PublisherRequest request)
        {
            var p = await _publisherRepository.CreatePublisher(_mapper.Map<Publisher>(request));
            _baseRepository.SaveChanges();
            return Ok(_mapper.Map<PublisherResponse>(p));
        }
    }
}
