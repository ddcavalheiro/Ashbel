﻿using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class CargoApp : ICargoApp<CargoModel>
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CargoModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<CargoModel> Post(CargoModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(CargoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
