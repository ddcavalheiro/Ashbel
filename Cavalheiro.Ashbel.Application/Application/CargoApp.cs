using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class CargoApp : ICargoApp<CargoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CargoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CargoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoModel>> List(CargoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoModel>> ListBasic(CargoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(CargoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
