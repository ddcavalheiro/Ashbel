using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class EBDAlunoApp : IEBDAlunoApp<EBD_AlunoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<EBD_AlunoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<EBD_AlunoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_AlunoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_AlunoModel>> List(EBD_AlunoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EBD_AlunoModel>> ListBasic(EBD_AlunoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(EBD_AlunoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
