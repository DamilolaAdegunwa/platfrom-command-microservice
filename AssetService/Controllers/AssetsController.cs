using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetService.Dtos;
using AssetService.Data;
using AssetService.Models;
using AutoMapper;

namespace AssetService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : Controller
    {
        private readonly IAssetRepo _AssetRepo;
        private readonly IMapper _mapper;

        public AssetsController(IAssetRepo AssetRepo, IMapper mapper)
        {
            _AssetRepo = AssetRepo;
            _mapper = mapper;
        }
        //public IActionResult Index()
        //{
        //    return Ok();
        //}

        [HttpGet]
        public ActionResult<IEnumerable<AssetReadDto>> GetAssets()
        {
            var Assets = _AssetRepo.GetAssets();
            return Ok(_mapper.Map<IEnumerable<AssetReadDto>>(Assets));
        }

        [HttpGet("{id}", Name = "[action]")]
        public ActionResult<AssetReadDto> GetAssetById(int id)
        {
            var Asset = _AssetRepo.GetAssetById(id);
            if(Asset != null)
            {
                return Ok(_mapper.Map<AssetReadDto>(Asset));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<AssetReadDto> CreateAsset(AssetCreateDto platfrom)
        {
            var p = _AssetRepo.CreateAsset(_mapper.Map<Asset>(platfrom));
            _AssetRepo.SaveChanges();
            return CreatedAtRoute(nameof(GetAssetById), new { Id = p.Id}, p);
        }
    }
}
