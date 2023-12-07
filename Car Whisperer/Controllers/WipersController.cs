using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Car_Whisperer.Data;
using Car_Whisperer.Entities;

namespace Car_Whisperer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WipersController : ControllerBase
    {
        private readonly CarWhispererDbContext _context;

        public WipersController(CarWhispererDbContext context)
        {
            _context = context;
        }

        // GET: api/Wipers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wiper>>> GetWipers()
        {
            return await _context.Wipers.ToListAsync();
        }

        // GET: api/Wipers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Wiper>> GetWiper(int id)
        {
            var wiper = await _context.Wipers.FindAsync(id);

            if (wiper == null)
            {
                return NotFound();
            }

            return wiper;
        }

        // PUT: api/Wipers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWiper(int id, Wiper wiper)
        {
            if (id != wiper.WiperCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(wiper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WiperExists(id))
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

        // POST: api/Wipers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Wiper>> PostWiper(Wiper wiper)
        {
            _context.Wipers.Add(wiper);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWiper", new { id = wiper.WiperCategoryId }, wiper);
        }

        // DELETE: api/Wipers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWiper(int id)
        {
            var wiper = await _context.Wipers.FindAsync(id);
            if (wiper == null)
            {
                return NotFound();
            }

            _context.Wipers.Remove(wiper);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WiperExists(int id)
        {
            return _context.Wipers.Any(e => e.WiperCategoryId == id);
        }
    }
}
