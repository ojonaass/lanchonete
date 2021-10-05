using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe a Matricula do aluno: ");
            aluno.Matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Nome do  aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a primeira nota: ");
            aluno.Nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            aluno.Nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota: ");
            aluno.Nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota: ");
            aluno.Nota4 = int.Parse(Console.ReadLine());

            Console.WriteLine(aluno.ObterMedia);
            if (aluno.AlunoEstaAprovado())
            {
                if (aluno.IndicadoParaMercado())
                {
                    Console.WriteLine("\nAluno está apto para o mercado.\n");
                }
            }
        }
    }
}
