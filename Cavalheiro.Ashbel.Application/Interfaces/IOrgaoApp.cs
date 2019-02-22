using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Interfaces
{
    public interface IOrgaoApp<TModel> : IApplication<TModel> where TModel : class
    {
    }
}
