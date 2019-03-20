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
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CargoGrupoTrabalhoModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CargoGrupoTrabalhoModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<CargoGrupoTrabalhoModel> Post(CargoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }

        public Task Put(CargoGrupoTrabalhoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
