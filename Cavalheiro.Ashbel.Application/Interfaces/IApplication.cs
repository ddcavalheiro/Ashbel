using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Application.Interfaces
{
    public interface IApplication<TModel> where TModel : class
    {
        /// <summary>
        /// Delete model by id
        /// </summary>
        /// <param name="id">Id of type long (for bigint IDs)</param>
        Task Delete(int id);

        /// <summary>
        /// Get model by id
        /// </summary>
        /// <param name="id">Id model</param>
        Task<TModel> Get(int id);

        /// <summary>
        /// List all
        /// </summary>
        /// <param name="model">Model object type with a filter</param>
        Task<IEnumerable<TModel>> Get();

        Task Put(TModel model);

        Task<TModel> Post(TModel model);
    }
}
