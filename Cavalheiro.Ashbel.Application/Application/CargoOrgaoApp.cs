using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class CargoOrgaoApp : ICargoOrgaoApp<CargoOrgaoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CargoOrgaoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CargoOrgaoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoOrgaoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoOrgaoModel>> List(CargoOrgaoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoOrgaoModel>> ListBasic(CargoOrgaoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(CargoOrgaoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
