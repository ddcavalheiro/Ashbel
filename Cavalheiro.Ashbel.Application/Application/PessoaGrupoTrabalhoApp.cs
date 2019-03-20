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
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaGrupoTrabalhoModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PessoaGrupoTrabalhoModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<PessoaGrupoTrabalhoModel> Post(PessoaGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(PessoaGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
