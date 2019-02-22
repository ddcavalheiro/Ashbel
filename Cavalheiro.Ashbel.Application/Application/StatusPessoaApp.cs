using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class StatusPessoaApp : IStatusPessoaApp<StatusPessoaModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<StatusPessoaModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<StatusPessoaModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StatusPessoaModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StatusPessoaModel>> List(StatusPessoaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StatusPessoaModel>> ListBasic(StatusPessoaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(StatusPessoaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
