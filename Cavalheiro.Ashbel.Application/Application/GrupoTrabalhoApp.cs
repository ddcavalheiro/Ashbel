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
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GrupoTrabalhoModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GrupoTrabalhoModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<GrupoTrabalhoModel> Post(GrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(GrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
