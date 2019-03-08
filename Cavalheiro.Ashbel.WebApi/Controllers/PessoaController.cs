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
    public class PessoaController : ControllerBase
    {
        private readonly AshbelDbContext _context;

        public PessoaController(AshbelDbContext context)
        {
            _context = context;
        }

        // GET: api/Pessoa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaModel>>> GetPessoa()
        {
            var teste = await _context.Pessoa.ToListAsync();

            return teste;
        }

        // GET: api/Pessoa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PessoaModel>> GetPessoaModel(int id)
        {
            var pessoaModel = await _context.Pessoa.FindAsync(id);

            if (pessoaModel == null)
            {
                return NotFound();
            }

            return pessoaModel;
        }

        // PUT: api/Pessoa/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoaModel(int id, PessoaModel pessoaModel)
        {
            if (id != pessoaModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(pessoaModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaModelExists(id))
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

        // POST: api/Pessoa
        [HttpPost]
        public async Task<ActionResult<PessoaModel>> PostPessoaModel(PessoaModel pessoaModel)
        {
            _context.Pessoa.Add(pessoaModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPessoaModel", new { id = pessoaModel.Id }, pessoaModel);
        }

        // DELETE: api/Pessoa/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PessoaModel>> DeletePessoaModel(int id)
        {
            var pessoaModel = await _context.Pessoa.FindAsync(id);
            if (pessoaModel == null)
            {
                return NotFound();
            }

            _context.Pessoa.Remove(pessoaModel);
            await _context.SaveChangesAsync();

            return pessoaModel;
        }

        private bool PessoaModelExists(int id)
        {
            return _context.Pessoa.Any(e => e.Id == id);
        }
    }
}
