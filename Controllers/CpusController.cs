using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CpusController : ControllerBase
    {
        private readonly PcBuilderContext _context;

        public CpusController(PcBuilderContext context)
        {
            _context = context;
        }

        // GET: api/Cpus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cpu>>> GetCpu()
        {
            if (_context.Cpu == null)
            {
                return NotFound();
            }
            return await _context.Cpu.ToListAsync();
        }

        // GET: api/Cpus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cpu>> GetCpu(int id)
        {
            if (_context.Cpu == null)
            {
                return NotFound();
            }
            var cpu = await _context.Cpu.FindAsync(id);

            if (cpu == null)
            {
                return NotFound();
            }

            return cpu;
        }

        // PUT: api/Cpus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCpu(int id, Cpu cpu)
        {
            if (id != cpu.Id)
            {
                return BadRequest();
            }

            _context.Entry(cpu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CpuExists(id))
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

        // POST: api/Cpus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cpu>> PostCpu(Cpu cpu)
        {
            if (_context.Cpu == null)
            {
                return Problem("Entity set 'PcBuilderContext.Cpu'  is null.");
            }
            _context.Cpu.Add(cpu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCpu", new { id = cpu.Id }, cpu);
        }

        // DELETE: api/Cpus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCpu(int id)
        {
            if (_context.Cpu == null)
            {
                return NotFound();
            }
            var cpu = await _context.Cpu.FindAsync(id);
            if (cpu == null)
            {
                return NotFound();
            }

            _context.Cpu.Remove(cpu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CpuExists(int id)
        {
            return (_context.Cpu?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
