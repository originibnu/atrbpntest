using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAtrBpnBackend.Models;

namespace TestAtrBpnBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LokasiPesertumsController : ControllerBase
    {
        private readonly PlaceContext _context;

        public LokasiPesertumsController(PlaceContext context)
        {
            _context = context;
        }

        // GET: api/LokasiPesertums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LokasiPesertum>>> GetLokasiPeserta()
        {
          if (_context.LokasiPeserta == null)
          {
              return NotFound();
          }
            return await _context.LokasiPeserta.ToListAsync();
        }

        // GET: api/LokasiPesertums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LokasiPesertum>> GetLokasiPesertum(int id)
        {
          if (_context.LokasiPeserta == null)
          {
              return NotFound();
          }
            var lokasiPesertum = await _context.LokasiPeserta.FindAsync(id);

            if (lokasiPesertum == null)
            {
                return NotFound();
            }

            return lokasiPesertum;
        }

        // PUT: api/LokasiPesertums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLokasiPesertum(int id, LokasiPesertum lokasiPesertum)
        {
            if (id != lokasiPesertum.Id)
            {
                return BadRequest();
            }

            _context.Entry(lokasiPesertum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LokasiPesertumExists(id))
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

        // POST: api/LokasiPesertums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LokasiPesertum>> PostLokasiPesertum(LokasiPesertum lokasiPesertum)
        {
          if (_context.LokasiPeserta == null)
          {
              return Problem("Entity set 'PlaceContext.LokasiPeserta'  is null.");
          }
            _context.LokasiPeserta.Add(lokasiPesertum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLokasiPesertum", new { id = lokasiPesertum.Id }, lokasiPesertum);
        }

        // DELETE: api/LokasiPesertums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLokasiPesertum(int id)
        {
            if (_context.LokasiPeserta == null)
            {
                return NotFound();
            }
            var lokasiPesertum = await _context.LokasiPeserta.FindAsync(id);
            if (lokasiPesertum == null)
            {
                return NotFound();
            }

            _context.LokasiPeserta.Remove(lokasiPesertum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LokasiPesertumExists(int id)
        {
            return (_context.LokasiPeserta?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
