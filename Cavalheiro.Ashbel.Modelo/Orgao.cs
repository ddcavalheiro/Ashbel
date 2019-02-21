using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class Orgao : BaseModel
    {
        public string Nome { get; set; }

        public int IdTipoOrgao { get; set; }

        #region Extras

        public TipoOrgao TipoOrgao { get; set; }
        #endregion

    }
}
