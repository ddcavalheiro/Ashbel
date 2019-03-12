using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class TipoGrupoTrabalhoApp : ITipoGrupoTrabalhoApp<TipoGrupoTrabalhoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TipoGrupoTrabalhoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<TipoGrupoTrabalhoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoGrupoTrabalhoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoGrupoTrabalhoModel>> List(TipoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoGrupoTrabalhoModel>> ListBasic(TipoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(TipoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
