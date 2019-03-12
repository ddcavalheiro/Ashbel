using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class PessoaGrupoTrabalhoModel : BaseModel
    {
        public int IdPessoa { get; set; }

        public int IdGrupoTrabalho { get; set; }

        public int IdCargo_GrupoTrabalho { get; set; }

        public DateTime DataFimVigencia { get; set; }

        #region Extras

        public PessoaModel Pessoa { get; set; }

        public PessoaModel GrupoTrabalho { get; set; }

        public CargoGrupoTrabalhoModel CargoGrupoTrabalho { get; set; }
        #endregion

    }
}
