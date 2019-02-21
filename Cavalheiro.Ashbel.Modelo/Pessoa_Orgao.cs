using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class Pessoa_Orgao : BaseModel
    {
        public int IdPessoa { get; set; }

        public int IdOrgao { get; set; }

        public int IdCargo_Orgao { get; set; }

        public DateTime DataFimVigencia { get; set; }

        #region Extras

        public Pessoa Pessoa { get; set; }

        public Pessoa Orgao { get; set; }

        public Cargo_Orgao CargoOrgao { get; set; }
        #endregion

    }
}
