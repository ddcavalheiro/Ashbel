using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class TipoOrgaoApp : ITipoOrgaoApp<TipoOrgaoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TipoOrgaoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<TipoOrgaoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoOrgaoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoOrgaoModel>> List(TipoOrgaoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoOrgaoModel>> ListBasic(TipoOrgaoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(TipoOrgaoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
