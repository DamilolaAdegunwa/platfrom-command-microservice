using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRMService.Dtos;
using CRMService.Data;
using CRMService.Models;
using AutoMapper;

namespace CRMService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRMsController : Controller
    {
        private readonly ICRMRepo _CRMRepo;
        private readonly IMapper _mapper;

        public CRMsController(ICRMRepo CRMRepo, IMapper mapper)
        {
            _CRMRepo = CRMRepo;
            _mapper = mapper;
        }
        //public IActionResult Index()
        //{
        //    return Ok();
        //}

        [HttpGet]
        public ActionResult<IEnumerable<CRMReadDto>> GetCRMs()
        {
            var CRMs = _CRMRepo.GetCRMs();
            return Ok(_mapper.Map<IEnumerable<CRMReadDto>>(CRMs));
        }

        [HttpGet("{id}", Name = "[action]")]
        public ActionResult<CRMReadDto> GetCRMById(int id)
        {
            var CRM = _CRMRepo.GetCRMById(id);
            if(CRM != null)
            {
                return Ok(_mapper.Map<CRMReadDto>(CRM));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CRMReadDto> CreateCRM(CRMCreateDto platfrom)
        {
            var p = _CRMRepo.CreateCRM(_mapper.Map<CRM>(platfrom));
            _CRMRepo.SaveChanges();
            return CreatedAtRoute(nameof(GetCRMById), new { Id = p.Id}, p);
        }
    }
}
