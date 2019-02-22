using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class EBD_AlunoModel : BaseModel
    {
        public int IdPessoa { get; set; }

        public int IdTurma { get; set; }

        public bool Matriculado { get; set; }

        #region Extras

        public PessoaModel Pessoa { get; set; }

        public EBD_TurmaModel Turma { get; set; }
        #endregion

    }
}
