using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class Cargo_Orgao : BaseModel
    {
        public int IdCargo { get; set; }

        public int IdOrgao { get; set; }

        #region Extras

        public Cargo Cargo { get; set; }

        public Orgao Orgao { get; set; }
        #endregion

    }
}
