using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; }

        public string UsuarioCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }

        public string UsuarioAlteracao { get; set; }

        public bool Ativo { get; set; }
    }
}
