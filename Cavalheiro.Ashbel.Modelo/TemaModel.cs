
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class TemaModel : BaseModel
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public List<AssuntoModel> Assuntos{ get; set; }
    }
}
