
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
[Route("api/[controller]")]
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeDto>> GetMakes()
        {
            var makes =  await _context.Makes.Include(m => m.Models).ToListAsync();
            return makes.Select(_mapper.Map<Make, MakeDto>);
        }
    }
}