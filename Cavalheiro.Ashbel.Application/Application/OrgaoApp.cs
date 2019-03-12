using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class GrupoTrabalhoApp : IGrupoTrabalhoApp<GrupoTrabalhoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<GrupoTrabalhoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<GrupoTrabalhoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GrupoTrabalhoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GrupoTrabalhoModel>> List(GrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GrupoTrabalhoModel>> ListBasic(GrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(GrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
