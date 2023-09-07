using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PcBuilderWebApi.Data;
using PcBuilderWebApi.Models;

namespace PcBuilderWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GpusController : ControllerBase
    {
        private readonly PcBuilderContext _context;

        public GpusController(PcBuilderContext context)
        {
            _context = context;
        }

        // GET: api/Gpus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gpu>>> GetGpu()
        {
          if (_context.Gpu == null)
          {
              return NotFound();
          }
            return await _context.Gpu.ToListAsync();
        }

        // GET: api/Gpus/5
        [HttpGet("{id}")]
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

        // PUT: api/Gpus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGpu(int id, Gpu gpu)
        {
            if (id != gpu.Id)
            {
                return BadRequest();
            }

            _context.Entry(gpu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GpuExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Gpus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Gpu>> PostGpu(Gpu gpu)
        {
          if (_context.Gpu == null)
          {
              return Problem("Entity set 'PcBuilderContext.Gpu'  is null.");
          }
            _context.Gpu.Add(gpu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGpu", new { id = gpu.Id }, gpu);
        }

        // DELETE: api/Gpus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGpu(int id)
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

            _context.Gpu.Remove(gpu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GpuExists(int id)
        {
            return (_context.Gpu?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
