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
        /// <param name="id">Id of type string</param>
        Task Delete(string id);

        /// <summary>
        /// Delete model by id
        /// </summary>
        /// <param name="id">Id of type long (for bigint IDs)</param>
        Task Delete(long id);

        /// <summary>
        /// Get model by id
        /// </summary>
        /// <param name="id">Id model</param>
        Task<TModel> Get(string id);

        /// <summary>
        /// Get model by id
        /// </summary>
        /// <param name="id">Id model</param>
        Task<TModel> Get(long id);

        /// <summary>
        /// List all
        /// </summary>
        /// <param name="model">Model object type with a filter</param>
        Task<IEnumerable<TModel>> List();

        /// <summary>
        /// List by filter
        /// </summary>
        /// <param name="model">Model object type with a filter</param>
        Task<IEnumerable<TModel>> List(TModel model);

        /// <summary>
        /// List by filter with basic fields from model
        /// </summary>
        /// <param name="filter">Model object type with a filter</param>
        Task<IEnumerable<TModel>> ListBasic(TModel model);

        /// <summary>
        /// Insert or update model
        /// </summary>
        /// <param name="model">Model object type</param>
        Task<IEnumerable<int>> Save(TModel model);
    }
}
