using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class EBDTurmaApp : IEBDTurmaApp<EBD_TurmaModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<EBD_TurmaModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EBD_TurmaModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_TurmaModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_TurmaModel>> List(EBD_TurmaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_TurmaModel>> ListBasic(EBD_TurmaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(EBD_TurmaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
