using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class AssuntoModel : BaseModel
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int IdTema { get; set; }

        #region extras

        public TemaModel Tema { get; set; }
        #endregion
    }
}
