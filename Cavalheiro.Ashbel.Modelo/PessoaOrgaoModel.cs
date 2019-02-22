using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class PessoaOrgaoModel : BaseModel
    {
        public int IdPessoa { get; set; }

        public int IdOrgao { get; set; }

        public int IdCargo_Orgao { get; set; }

        public DateTime DataFimVigencia { get; set; }

        #region Extras

        public PessoaModel Pessoa { get; set; }

        public PessoaModel Orgao { get; set; }

        public CargoOrgaoModel CargoOrgao { get; set; }
        #endregion

    }
}
