using Escola.ConsoleApp.AlunoFeature;
using Escola.ConsoleApp.AulaFeature;
using Escola.ConsoleApp.ProfessorFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Crud escola :)\n");

                Console.WriteLine("Aperte 1 para Adicionar Aluno");

                Console.WriteLine("Aperte 2 para Adicionar Professor");

                Console.WriteLine("Aperte 3 para Adicionar Aula");

                Console.WriteLine("Aperte S para Sair");

                Console.Write("\nOpção: ");

                string opcao = Console.ReadLine();

                if (!IniciarOpcao(opcao))
                    break;
            }
        }

        private static bool IniciarOpcao(string opcao)
        {
            switch (opcao.ToUpper())
            {
                case "1": new TelaAluno(); return true;
                case "2": new TelaProfessor(); return true;
                case "3": new TelaAula(); return true;
                case "S": return false;
                default: return true;
            }
        }
    }
}
