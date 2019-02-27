using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class EBD_Assunto : BaseModel
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int IdTema { get; set; }

        #region extras

        public EBD_Tema Tema { get; set; }
        #endregion
    }
}
