using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cavalheiro.Ashbel.Model;
using Cavalheiro.Ashbel.Persistance;
using Cavalheiro.Ashbel.Application.Interfaces;

namespace Cavalheiro.Ashbel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly AshbelDbContext _context;
        private readonly IPessoaApp<PessoaModel> _app;

        public PessoaController(AshbelDbContext context, IPessoaApp<PessoaModel> app)
        {
            _context = context;
            _app = app;
        }

        // GET: api/Pessoa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaModel>>> Get()
        {
            var list = await _app.Get();

            return Ok(list);
        }

        // GET: api/Pessoa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PessoaModel>> Get(int id)
        {
            var pessoaModel = await _app.Get(id);

            if (pessoaModel == null)
            {
                return NotFound();
            }

            return Ok(pessoaModel);
        }

        // PUT: api/Pessoa/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PessoaModel pessoaModel)
        {
            if (id != pessoaModel.Id)
            {
                return BadRequest();
            }

            try
            {
                await _app.Put(pessoaModel);
            }
            catch (Exception)
            {
                    throw;
            }

            return NoContent();
        }

        // POST: api/Pessoa
        [HttpPost]
        public async Task<ActionResult<PessoaModel>> PostPessoaModel(PessoaModel pessoaModel)
        {
            return await _app.Post(pessoaModel);
        }

        // DELETE: api/Pessoa/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _app.Delete(id);
        }

    }
}
