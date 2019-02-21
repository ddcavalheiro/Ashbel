using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class EBD_Aluno : BaseModel
    {
        public int IdPessoa { get; set; }

        public int IdTurma { get; set; }

        public bool Matriculado { get; set; }

        #region Extras

        public Pessoa Pessoa { get; set; }

        public EBD_Turma Turma { get; set; }
        #endregion

    }
}
