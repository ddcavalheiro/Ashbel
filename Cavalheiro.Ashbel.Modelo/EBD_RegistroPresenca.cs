﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class EBD_RegistroPresenca : BaseModel
    {
        public int IdAula { get; set; }

        public int IdAluno { get; set; }

        public bool TrouxeBiblia { get; set; }

        public bool Presente { get; set; }

        public bool Visita { get; set; }

        #region Extras

        public EBD_Aula Aula { get; set; }

        public EBD_Aluno Aluno { get; set; }

        #endregion

    }
}
