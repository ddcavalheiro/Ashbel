using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class CargoOrgaoModel : BaseModel
    {
        public int IdCargo { get; set; }

        public int IdOrgao { get; set; }

        #region Extras

        public CargoModel Cargo { get; set; }

        public OrgaoModel Orgao { get; set; }
        #endregion

    }
}
