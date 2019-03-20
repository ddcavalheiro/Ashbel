using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class TurmaApp : ITurmaApp<TurmaModel>
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TurmaModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TurmaModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<TurmaModel> Post(TurmaModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(TurmaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
