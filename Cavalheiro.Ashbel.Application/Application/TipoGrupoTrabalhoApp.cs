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
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TipoGrupoTrabalhoModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoGrupoTrabalhoModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<TipoGrupoTrabalhoModel> Post(TipoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(TipoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
