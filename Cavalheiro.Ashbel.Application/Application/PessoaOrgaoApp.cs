using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class PessoaOrgaoApp : IPessoaOrgaoApp<PessoaOrgaoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaOrgaoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaOrgaoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PessoaOrgaoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PessoaOrgaoModel>> List(PessoaOrgaoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PessoaOrgaoModel>> ListBasic(PessoaOrgaoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(PessoaOrgaoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
