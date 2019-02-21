using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class Afiliacao_Pessoa : BaseModel
    {
        public int IdPessoa { get; set; }

        public int IdAfiliacao { get; set; }

        public int IdPessoaAfiliacao { get; set; }
    }
}
