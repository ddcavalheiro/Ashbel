using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class PessoaModel : BaseModel
    {
        public string Nome { get; set; }

        public bool Membro { get; set; }

        public int IdStatusPessoa { get; set; }

        public int? IdPessoaInfoAdicional { get; set; }

        public int? IdAluno { get; set; }

        public int? IdPessoaPai { get; set; }

        public int? IdPessoaConjugue { get; set; }

        #region Extras

        public AlunoModel Aluno { get; set; }

        public List<PessoaContatoModel> Contatos { get; set; }

        public List<PessoaEnderecoModel> Enderecos { get; set; }

        public PessoaInfoAdicionalModel InfoAdicional { get; set; }

        public StatusPessoaModel Status { get; set; }

        public PessoaModel Pai { get; set; }

        public PessoaModel Conjugue { get; set; }

        #endregion

    }
}
