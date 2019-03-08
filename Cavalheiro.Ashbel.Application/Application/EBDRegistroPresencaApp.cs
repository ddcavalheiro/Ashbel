using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class EBDRegistroPresencaApp : IEBDRegistroPresencaApp<RegistroPresencaModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<RegistroPresencaModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<RegistroPresencaModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RegistroPresencaModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RegistroPresencaModel>> List(RegistroPresencaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RegistroPresencaModel>> ListBasic(RegistroPresencaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(RegistroPresencaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
