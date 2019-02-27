using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class EBD_TurmaModel : BaseModel
    {
        public string Nome { get; set; }

        public int IdadeMinima { get; set; }

        public int IdadeMaxima { get; set; }
    }
}
