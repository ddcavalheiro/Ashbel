using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class CargoModel : BaseModel
    {
        public string Nome { get; set; }

        #region Extras
        public List<CargoOrgaoModel> CargoOrgaos { get; set; }
        #endregion
    }
}
