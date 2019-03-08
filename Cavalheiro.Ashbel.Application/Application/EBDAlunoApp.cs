using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class EBDAlunoApp : IEBDAlunoApp<AlunoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<AlunoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<AlunoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AlunoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AlunoModel>> List(AlunoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AlunoModel>> ListBasic(AlunoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(AlunoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
