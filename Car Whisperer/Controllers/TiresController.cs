using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Car_Whisperer;
using Car_Whisperer.Data;
using Car_Whisperer.Entities;



namespace Car_Whisperer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiresController : ControllerBase
    {
        private readonly CarWhispererDbContext _context;

        public TiresController(CarWhispererDbContext context)
        {
            _context = context;
        }

        // GET: api/Tires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tire>>> GetTire()
        {
            return await _context.Tires.ToListAsync();
        }

        // GET: api/Tires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tire>> GetTire(int id)
        {
            var tire = await _context.Tires.FindAsync(id);

            if (tire == null)
            {
                return NotFound();
            }

            return tire;
        }

        // PUT: api/Tires/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTire(int id, Tire tire)
        {
            if (id != tire.TireId)
            {
                return BadRequest();
            }

            _context.Entry(tire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TireExists(id))
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

        // POST: api/Tires
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tire>> PostTire(Tire tire)
        {
            _context.Tires.Add(tire);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTire", new { id = tire.TireId }, tire);
        }

        // DELETE: api/Tires/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTire(int id)
        {
            var tire = await _context.Tires.FindAsync(id);
            if (tire == null)
            {
                return NotFound();
            }

            _context.Tires.Remove(tire);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TireExists(int id)
        {
            return _context.Tires.Any(e => e.TireId == id);
        }
    }
}
