using Escola.Dominio.AulaModule;
using Escola.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Dominio.ProfessorModule
{
    public class Professor : Pessoa
    {
        public IList<Aula> Aulas { get; set; }
        public Professor()
        {

        }
        public Professor(string nome, string endereco, DateTime dataNascimento, int idade)
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
