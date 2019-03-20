using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class AlunoApp : IAlunoApp<AlunoModel>
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AlunoModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AlunoModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<AlunoModel> Post(AlunoModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(AlunoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
