using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatedraticoModel.Modelo;
using Tarea_ArqComp.Data;

namespace Tarea_ArqComp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatedraticoesController : ControllerBase
    {
        private readonly Tarea_ArqCompContext _context;

        public CatedraticoesController(Tarea_ArqCompContext context)
        {
            _context = context;
        }

        // GET: api/Catedraticoes
        [HttpGet]
        public IEnumerable<Catedratico> GetCatedratico()
        {
            return _context.Catedratico;
        }

        // GET: api/Catedraticoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCatedratico([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var catedratico = await _context.Catedratico.FindAsync(id);

            if (catedratico == null)
            {
                return NotFound();
            }

            return Ok(catedratico);
        }

        // PUT: api/Catedraticoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCatedratico([FromRoute] int id, [FromBody] Catedratico catedratico)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != catedratico.IdCatedratico)
            {
                return BadRequest();
            }

            _context.Entry(catedratico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CatedraticoExists(id))
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

        // POST: api/Catedraticoes
        [HttpPost]
        public async Task<IActionResult> PostCatedratico([FromBody] Catedratico catedratico)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Catedratico.Add(catedratico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCatedratico", new { id = catedratico.IdCatedratico }, catedratico);
        }

        // DELETE: api/Catedraticoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCatedratico([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var catedratico = await _context.Catedratico.FindAsync(id);
            if (catedratico == null)
            {
                return NotFound();
            }

            _context.Catedratico.Remove(catedratico);
            await _context.SaveChangesAsync();

            return Ok(catedratico);
        }

        private bool CatedraticoExists(int id)
        {
            return _context.Catedratico.Any(e => e.IdCatedratico == id);
        }
    }
}