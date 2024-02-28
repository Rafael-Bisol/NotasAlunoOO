using System;

namespace NotasAlunoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Notas do Aluno");
            Console.Write("Nome do Aluno: ");
            aluno.nome = Console.ReadLine();
            Console.Write("Nota do primeiro trimestre: ");
            aluno.nota1 = int.Parse(Console.ReadLine());
            Console.Write("Nota do segundo trimestre: ");
            aluno.nota2 = int.Parse(Console.ReadLine());
            Console.Write("Nota do terceiro trimestre: ");
            aluno.nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Aluno {aluno.nome} tirou {aluno.Media()}");

            if (aluno.Media() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltam {0} para atingir 60 pontos", 60 - aluno.Media());
            }
        }
    }
}
