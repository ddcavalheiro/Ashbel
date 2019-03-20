using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using Cavalheiro.Ashbel.Persistance.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class PessoaApp : IPessoaApp<PessoaModel>
    {
        PessoaRepo _repo;
        public PessoaApp(IConfiguration config)
        {
            _repo = new PessoaRepo(config);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<PessoaModel> Get(int id)
        {
            return await _repo.Get(id);
        }

        public async Task<IEnumerable<PessoaModel>> Get()
        {
            return await _repo.Get();
        }

        public async Task<PessoaModel> Post(PessoaModel model)
        {
            return await _repo.Post(model);
        }

        public async Task Put(PessoaModel model)
        {
            await _repo.Put(model);
        }
    }
}
