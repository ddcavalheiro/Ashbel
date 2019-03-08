using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class RegistroPresencaModel : BaseModel
    {
        public int IdAula { get; set; }

        public int IdAluno { get; set; }

        public bool TrouxeBiblia { get; set; }

        public bool Presente { get; set; }

        public bool Visita { get; set; }

        #region Extras

        public AulaModel Aula { get; set; }

        public AlunoModel Aluno { get; set; }

        #endregion

    }
}
