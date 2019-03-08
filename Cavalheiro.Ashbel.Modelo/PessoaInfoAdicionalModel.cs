using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class PessoaInfoAdicionalModel : BaseModel
    {
        public int IdPessoa { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Profissao { get; set; }

        public string Empresa { get; set; }

        public Byte[] Foto { get; set; }

        public string NaturalCidade { get; set; }

        public string NaturalEstado { get; set; }

        public string NaturalPais { get; set; }

        public bool MembroProfesso { get; set; }

        public bool Batizado { get; set; }


        #region Extras
        public PessoaModel Pessoa { get; set; }

        #endregion

    }
}
