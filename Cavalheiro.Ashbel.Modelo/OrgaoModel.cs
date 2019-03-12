using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class OrgaoModel : BaseModel
    {
        public string Nome { get; set; }

        public int IdTipoOrgao { get; set; }

        #region Extras

        public TipoOrgaoModel TipoOrgao { get; set; }

        public List<CargoOrgaoModel> OrgaoCargos { get; set; }
        #endregion

    }
}
