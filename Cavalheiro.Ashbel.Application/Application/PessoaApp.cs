using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class PessoaApp : IPessoaApp<PessoaModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
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

        public Task<IEnumerable<PessoaModel>> List()
        {
            throw new NotImplementedException();
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
