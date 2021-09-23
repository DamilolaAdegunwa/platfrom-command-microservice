using LocationService.Data.Repositories;
using LocationService.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LocationService.Models;

namespace LocationService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public LocationController(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }
        [HttpGet("ping")]
        public IActionResult Index()
        {
            return Ok("Location api is running");
        }
        [HttpPost]
        public async Task<ActionResult<LocationReadDto>> Add(LocationCreateDto location)
        {
            var resp = await _locationRepository.CreateLocation(_mapper.Map<Location>(location));
            if(resp != null)
            {
                return Ok(_mapper.Map<LocationReadDto>(resp));
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationReadDto>> Get(int id)
        {
            var resp = await _locationRepository.GetLocation(id);
            if (resp != null)
            {
                return Ok(_mapper.Map<LocationReadDto>(resp));
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationReadDto>>> GetAll()
        {
            var resp = await _locationRepository.GetLocations();

            return Ok(_mapper.Map<IEnumerable<LocationReadDto>>(resp));
        }
    }
}
