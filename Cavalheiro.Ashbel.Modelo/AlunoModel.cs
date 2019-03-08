using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class AlunoModel : BaseModel
    {
        public int IdPessoa { get; set; }

        public int IdTurma { get; set; }

        public bool Matriculado { get; set; }

        #region Extras

        public PessoaModel Pessoa { get; set; }

        public TurmaModel Turma { get; set; }
        #endregion

    }
}
