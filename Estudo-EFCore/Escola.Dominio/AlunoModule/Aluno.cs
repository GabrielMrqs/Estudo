using Escola.Dominio.AulaModule;
using Escola.Dominio.Shared;
using System;
using System.Collections.Generic;

namespace Escola.Dominio.AlunoModule
{
    public class Aluno : Pessoa
    {
        public IList<Aula> Aulas { get; set; }
        public Aluno()
        {

        }
        public Aluno(string nome, string endereco, DateTime dataNascimento, int idade)
        {
            Nome = nome;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Idade = idade;
        }
        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome}";
        }
    }
}
