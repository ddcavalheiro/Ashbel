using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class EBDRegistroPresencaApp : IEBDRegistroPresencaApp<EBD_RegistroPresencaModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<EBD_RegistroPresencaModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EBD_RegistroPresencaModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_RegistroPresencaModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_RegistroPresencaModel>> List(EBD_RegistroPresencaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_RegistroPresencaModel>> ListBasic(EBD_RegistroPresencaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(EBD_RegistroPresencaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
