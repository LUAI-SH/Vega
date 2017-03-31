using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Dtos;
using vega.Models;
using System.Linq;


namespace vega.Controllers
{
    public class FeatureseController
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;
        public FeatureseController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureDto>> GetFeatures()
        {
            var features =  await _context.Features.ToListAsync();
            return features.Select(_mapper.Map<Feature, FeatureDto>) ;
        }
    }
}