using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class PessoaGrupoTrabalhoApp : IPessoaGrupoTrabalhoApp<PessoaGrupoTrabalhoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaGrupoTrabalhoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaGrupoTrabalhoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PessoaGrupoTrabalhoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PessoaGrupoTrabalhoModel>> List(PessoaGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PessoaGrupoTrabalhoModel>> ListBasic(PessoaGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(PessoaGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
