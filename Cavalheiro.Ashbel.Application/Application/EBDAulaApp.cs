using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class EBDAulaApp : IEBDAulaApp<AulaModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<AulaModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AulaModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AulaModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AulaModel>> List(AulaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AulaModel>> ListBasic(AulaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(AulaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
