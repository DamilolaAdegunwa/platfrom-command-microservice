using ResidentService.Data.Repositories;
using ResidentService.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ResidentService.Models;

namespace ResidentService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResidentController : ControllerBase
    {
        private readonly IResidentRepository _ResidentRepository;
        private readonly IMapper _mapper;

        public ResidentController(IResidentRepository ResidentRepository, IMapper mapper)
        {
            _ResidentRepository = ResidentRepository;
            _mapper = mapper;
        }
        [HttpGet("ping")]
        public IActionResult Index()
        {
            return Ok("Resident api is running");
        }
        [HttpPost]
        public async Task<ActionResult<ResidentReadDto>> Add(ResidentCreateDto Resident)
        {
            var resp = await _ResidentRepository.CreateResident(_mapper.Map<Resident>(Resident));
            if(resp != null)
            {
                return Ok(_mapper.Map<ResidentReadDto>(resp));
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ResidentReadDto>> Get(int id)
        {
            var resp = await _ResidentRepository.GetResident(id);
            if (resp != null)
            {
                return Ok(_mapper.Map<ResidentReadDto>(resp));
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResidentReadDto>>> GetAll()
        {
            var resp = await _ResidentRepository.GetResidents();

            return Ok(_mapper.Map<IEnumerable<ResidentReadDto>>(resp));
        }
    }
}
