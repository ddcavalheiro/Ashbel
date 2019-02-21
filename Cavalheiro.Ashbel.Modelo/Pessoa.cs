using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Model
{
    public class Pessoa : BaseModel
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string TelefoneCelular { get; set; }

        public string TelefoneFixo { get; set; }

        public string Email { get; set; }

        public string Profissao { get; set; }

        public string Empresa { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public Byte[] Foto { get; set; }

        public string NaturalCidade { get; set; }

        public string NaturalEstado { get; set; }

        public string NaturalPais { get; set; }

        public bool MembroProfesso { get; set; }

        public bool Batizado { get; set; }

        public bool Membro { get; set; }

        public int IdConjugue { get; set; }

        public int IdPai { get; set; }

        public int IdStatusPessoa { get; set; }

        #region Extras

        public Pessoa Pai { get; set; }

        public Pessoa Conjugue { get; set; }

        public StatusPessoa Status { get; set; }
        #endregion

    }
}
