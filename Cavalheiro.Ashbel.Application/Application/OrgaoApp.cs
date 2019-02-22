using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class OrgaoApp : IOrgaoApp<OrgaoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<OrgaoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<OrgaoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrgaoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrgaoModel>> List(OrgaoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrgaoModel>> ListBasic(OrgaoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(OrgaoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
