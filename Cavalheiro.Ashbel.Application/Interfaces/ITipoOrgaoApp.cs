using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Interfaces
{
    public interface ITipoGrupoTrabalhoApp<TModel> : IApplication<TModel> where TModel : class
    {
    }
}
