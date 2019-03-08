using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class PessoaContatoModel : BaseModel
    {
        public int IdPessoa { get; set; }

        public string TelefoneCelular { get; set; }

        public string TelefoneFixo { get; set; }

        public string Email { get; set; }

    }
}
