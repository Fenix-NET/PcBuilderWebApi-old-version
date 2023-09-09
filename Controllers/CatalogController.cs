using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PcBuilderWebApi.Data;
using PcBuilderWebApi.Models;
using System.Linq;

namespace PcBuilderWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly PcBuilderContext _context;

        public CatalogController(PcBuilderContext context)
        {
            _context = context;
        }

        [HttpGet("cpu")]
        public async Task<ActionResult<IEnumerable<Cpu>>> GetAllCpu()
        {
            if (_context.Cpu == null)
            {
                return NotFound();
            }
            return await _context.Cpu.ToListAsync();
        }

        [HttpGet("gpu")]
        public async Task<ActionResult<IEnumerable<Gpu>>> GetAllGpu()
        {
            if (_context.Gpu == null)
            {
                return NotFound();
            }
            return await _context.Gpu.ToListAsync();
        }

        [HttpGet("gpu/{sort}")]
        //public async Task<ActionResult<IEnumerable<Gpu>>> GetAllGpuFilter(int? minPrice, int? maxPrice, string? manf, string? prod) 
        //{
        //    if (_context.Gpu == null)
        //    {
        //        return NotFound();
        //    }
        //    if (sort == "minPrice")
        //        return await _context.Gpu.OrderBy(p => p.Price).ToListAsync();
        //    if (sort == "maxPrice")
        //        return await _context.Gpu.OrderByDescending(p => p.Price).ToListAsync();
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
        [HttpGet("gpu/{id}")]
        public async Task<ActionResult<Gpu>> GetGpu(int id)
        {
            if (_context.Gpu == null)
            {
                return NotFound();
            }
            var gpu = await _context.Gpu.FindAsync(id);

            if (gpu == null)
            {
                return NotFound();
            }

            return gpu;
        }

        [HttpGet("corpus")]
        public async Task<ActionResult<IEnumerable<Case>>> GetAllCase()
        {
            if (_context.Case == null)
            {
                return NotFound();
            }
            return await _context.Case.ToListAsync();
        }

        [HttpGet("hdd")]
        public async Task<ActionResult<IEnumerable<Hdd>>> GetAllHdd()
        {
            if (_context.Hdd == null)
            {
                return NotFound();
            }
            return await _context.Hdd.ToListAsync();
        }

        [HttpGet("motherboard")]
        public async Task<ActionResult<IEnumerable<Motherboard>>> GetAllMotherBoards()
        {
            if (_context.Motherboards == null)
            {
                return NotFound();
            }
            return await _context.Motherboards.ToListAsync();
        }

        [HttpGet("psu")]
        public async Task<ActionResult<IEnumerable<Psu>>> GetAllPsu()
        {
            if (_context.Psu == null)
            {
                return NotFound();
            }
            return await _context.Psu.ToListAsync();
        }

        [HttpGet("ram")]
        public async Task<ActionResult<IEnumerable<Ram>>> GetAllRam()
        {
            if (_context.Ram == null)
            {
                return NotFound();
            }
            return await _context.Ram.ToListAsync();
        }

        [HttpGet("ssd")]
        public async Task<ActionResult<IEnumerable<Ssd>>> GetAllSsd()
        {
            if (_context.Ssd == null)
            {
                return NotFound();
            }
            return await _context.Ssd.ToListAsync();
        }
    }
}
