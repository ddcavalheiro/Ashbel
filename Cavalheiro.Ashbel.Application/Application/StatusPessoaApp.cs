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
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StatusPessoaModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StatusPessoaModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<StatusPessoaModel> Post(StatusPessoaModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(StatusPessoaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
