using Cavalheiro.Ashbel.Application.Interfaces;
using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Application
{
    public class CargoGrupoTrabalhoApp : ICargoGrupoTrabalhoApp<CargoGrupoTrabalhoModel>
    {
        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CargoGrupoTrabalhoModel> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CargoGrupoTrabalhoModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoGrupoTrabalhoModel>> List()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoGrupoTrabalhoModel>> List(CargoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoGrupoTrabalhoModel>> ListBasic(CargoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<int>> Save(CargoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
