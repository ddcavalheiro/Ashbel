using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cavalheiro.Ashbel.Model;
using Cavalheiro.Ashbel.Persistance;

namespace Cavalheiro.Ashbel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly AshbelDbContext _context;

        public TurmaController(AshbelDbContext context)
        {
            _context = context;
        }

        // GET: api/Turma
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TurmaModel>>> GetTurma()
        {
            return await _context.Turma.ToListAsync();
        }

        // GET: api/Turma/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TurmaModel>> GetTurmaModel(int id)
        {
            var turmaModel = await _context.Turma.FindAsync(id);

            if (turmaModel == null)
            {
                return NotFound();
            }

            return turmaModel;
        }

        // PUT: api/Turma/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurmaModel(int id, TurmaModel turmaModel)
        {
            if (id != turmaModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(turmaModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TurmaModelExists(id))
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

        // POST: api/Turma
        [HttpPost]
        public async Task<ActionResult<TurmaModel>> PostTurmaModel(TurmaModel turmaModel)
        {
            _context.Turma.Add(turmaModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTurmaModel", new { id = turmaModel.Id }, turmaModel);
        }

        // DELETE: api/Turma/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TurmaModel>> DeleteTurmaModel(int id)
        {
            var turmaModel = await _context.Turma.FindAsync(id);
            if (turmaModel == null)
            {
                return NotFound();
            }

            _context.Turma.Remove(turmaModel);
            await _context.SaveChangesAsync();

            return turmaModel;
        }

        private bool TurmaModelExists(int id)
        {
            return _context.Turma.Any(e => e.Id == id);
        }
    }
}
