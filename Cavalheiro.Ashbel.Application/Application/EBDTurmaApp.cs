﻿using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class EBDTurmaApp : IEBDTurmaApp<TurmaModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TurmaModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<TurmaModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TurmaModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TurmaModel>> List(TurmaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TurmaModel>> ListBasic(TurmaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(TurmaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
