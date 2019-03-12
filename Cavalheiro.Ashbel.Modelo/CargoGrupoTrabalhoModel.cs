using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class CargoGrupoTrabalhoModel : BaseModel
    {
        public int IdCargo { get; set; }

        public int IdGrupoTrabalho { get; set; }

        #region Extras

        public CargoModel Cargo { get; set; }

        public GrupoTrabalhoModel GrupoTrabalho { get; set; }
        #endregion

    }
}
