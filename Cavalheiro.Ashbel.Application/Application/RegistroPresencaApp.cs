using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class RegistroPresencaApp : IRegistroPresencaApp<RegistroPresencaModel>
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RegistroPresencaModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RegistroPresencaModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<RegistroPresencaModel> Post(RegistroPresencaModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(RegistroPresencaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
