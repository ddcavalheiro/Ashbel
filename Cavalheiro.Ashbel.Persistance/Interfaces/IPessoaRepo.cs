using Cavalheiro.Ashbel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Persistance.Interfaces
{
    public interface IPessoaRepo
    {
        Task<PessoaModel> GetById(int id);
        
        Task<List<PessoaModel>> GetAll();
    }
}
