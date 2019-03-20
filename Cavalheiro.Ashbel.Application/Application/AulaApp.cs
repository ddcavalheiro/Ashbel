using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class AulaApp : IAulaApp<AulaModel>
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AulaModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AulaModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<AulaModel> Post(AulaModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(AulaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
