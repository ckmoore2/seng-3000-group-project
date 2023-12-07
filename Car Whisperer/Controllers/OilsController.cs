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
    public class OilsController : ControllerBase
    {
        private readonly CarWhispererDbContext _context;

        public OilsController(CarWhispererDbContext context)
        {
            _context = context;
        }

        // GET: api/Oils
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oil>>> GetOils()
        {
            return await _context.Oils.ToListAsync();
        }

        // GET: api/Oils/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Oil>> GetOil(int id)
        {
            var oil = await _context.Oils.FindAsync(id);

            if (oil == null)
            {
                return NotFound();
            }

            return oil;
        }

        // PUT: api/Oils/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOil(int id, Oil oil)
        {
            if (id != oil.OilCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(oil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OilExists(id))
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

        // POST: api/Oils
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Oil>> PostOil(Oil oil)
        {
            _context.Oils.Add(oil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOil", new { id = oil.OilCategoryId }, oil);
        }

        // DELETE: api/Oils/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOil(int id)
        {
            var oil = await _context.Oils.FindAsync(id);
            if (oil == null)
            {
                return NotFound();
            }

            _context.Oils.Remove(oil);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OilExists(int id)
        {
            return _context.Oils.Any(e => e.OilCategoryId == id);
        }
    }
}
