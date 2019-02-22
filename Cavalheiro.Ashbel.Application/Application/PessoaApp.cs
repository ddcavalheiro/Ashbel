using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using Cavalheiro.Ashbel.Persistance.Interfaces;
using Cavalheiro.Ashbel.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class PessoaApp : IPessoaApp<PessoaModel>
    {
        IPessoaRepo _pessoaRepo;
        public PessoaApp(IPessoaRepo pessoaRepo)
        {
            _pessoaRepo = pessoaRepo;
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PessoaModel>> List()
        {
            return await _pessoaRepo.GetAll();
        }

        public Task<IEnumerable<PessoaModel>> List(PessoaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PessoaModel>> ListBasic(PessoaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(PessoaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
