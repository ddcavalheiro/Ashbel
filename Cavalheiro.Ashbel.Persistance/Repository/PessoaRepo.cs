using Cavalheiro.Ashbel.Model;
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
    public class PessoaRepo
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

        public async Task<List<PessoaModel>> Get()
        {
            using (IDbConnection conn = Connection)
            {
                string sQuery = "SELECT * FROM PESSOA";
                conn.Open();
                var result = await conn.QueryAsync<PessoaModel>(sQuery);

                return result.ToList();
            }
        }

        public async Task<PessoaModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
        }

        public async Task<PessoaModel> Post(PessoaModel model)
        {
            throw new NotImplementedException();
        }
        public async Task Put(PessoaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
