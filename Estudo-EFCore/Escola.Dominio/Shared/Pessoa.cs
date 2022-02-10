using System;

namespace Escola.Dominio.Shared
{
    public class Pessoa : EntidadeBase
    {
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
