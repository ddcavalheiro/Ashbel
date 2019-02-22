using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class EBDAulaApp : IEBDAulaApp<EBD_AulaModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<EBD_AulaModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EBD_AulaModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_AulaModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_AulaModel>> List(EBD_AulaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_AulaModel>> ListBasic(EBD_AulaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(EBD_AulaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
