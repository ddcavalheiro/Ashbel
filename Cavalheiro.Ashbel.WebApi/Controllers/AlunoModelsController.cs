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
    public class AlunoModelsController : ControllerBase
    {
        private readonly AshbelDbContext _context;

        public AlunoModelsController(AshbelDbContext context)
        {
            _context = context;
        }

        // GET: api/AlunoModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlunoModel>>> GetAluno()
        {
            return await _context.Aluno.ToListAsync();
        }

        // GET: api/AlunoModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlunoModel>> GetAlunoModel(int id)
        {
            var alunoModel = await _context.Aluno.FindAsync(id);

            if (alunoModel == null)
            {
                return NotFound();
            }

            return alunoModel;
        }

        // PUT: api/AlunoModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlunoModel(int id, AlunoModel alunoModel)
        {
            if (id != alunoModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(alunoModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlunoModelExists(id))
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

        // POST: api/AlunoModels
        [HttpPost]
        public async Task<ActionResult<AlunoModel>> PostAlunoModel(AlunoModel alunoModel)
        {
            _context.Aluno.Add(alunoModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlunoModel", new { id = alunoModel.Id }, alunoModel);
        }

        // DELETE: api/AlunoModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AlunoModel>> DeleteAlunoModel(int id)
        {
            var alunoModel = await _context.Aluno.FindAsync(id);
            if (alunoModel == null)
            {
                return NotFound();
            }

            _context.Aluno.Remove(alunoModel);
            await _context.SaveChangesAsync();

            return alunoModel;
        }

        private bool AlunoModelExists(int id)
        {
            return _context.Aluno.Any(e => e.Id == id);
        }
    }
}
