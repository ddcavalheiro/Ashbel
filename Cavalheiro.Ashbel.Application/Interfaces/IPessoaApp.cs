using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Interfaces
{
    public interface IPessoaApp<TModel> : IApplication<TModel> where TModel : class
    {
    }
}
