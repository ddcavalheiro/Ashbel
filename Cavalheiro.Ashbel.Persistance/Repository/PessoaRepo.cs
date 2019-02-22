using Cavalheiro.Ashbel.Model;
using Cavalheiro.Ashbel.Persistance.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cavalheiro.Ashbel.Persistance.Repository
{
    public class PessoaRepo : IPessoaRepo
    {
        private readonly IConfiguration _config;

        public PessoaRepo(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("Ashbel"));
            }
        }

        public async Task<List<PessoaModel>> GetAll()
        {
            using (IDbConnection conn = Connection)
            {
                string sQuery = "SELECT ID, FirstName, LastName, DateOfBirth FROM Employee";
                conn.Open();
                var result = await conn.QueryAsync<PessoaModel>(sQuery);

                return result.ToList();
            }
        }

        public Task<PessoaModel> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
