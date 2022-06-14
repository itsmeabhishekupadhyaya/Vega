using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vega.Controllers.Resources;
using Vega.Models;
using Vega.Persistence;

namespace Vega.Controllers
{
    public class MakesControllers : Controller
    {
        private readonly VegaDbContext _context;

        public MakesControllers(VegaDbContext _context, IMapper mapper)
        {
            this._context = _context;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes= await _context.Makes.Include(m => m.Models).ToListAsync();
            return Mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}