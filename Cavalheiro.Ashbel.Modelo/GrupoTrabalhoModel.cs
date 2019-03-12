using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    /// <summary>
    /// renomear para grupo de trabalho
    /// </summary>
    public class GrupoTrabalhoModel : BaseModel
    {
        public string Nome { get; set; }

        public int IdTipoGrupoTrabalho { get; set; }

        #region Extras

        public TipoGrupoTrabalhoModel TipoGrupoTrabalho { get; set; }

        public List<CargoGrupoTrabalhoModel> GrupoTrabalhoCargos { get; set; }
        #endregion

    }
}
