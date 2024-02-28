using System;

namespace NotasAlunoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notas do Aluno");
            Console.Write("Nome do Aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Nota do primeiro trimestre: ");
            int primeiroTrimestre = int.Parse(Console.ReadLine());
            Console.Write("Nota do segundo trimestre: ");
            int segundoTrimestre = int.Parse(Console.ReadLine());
            Console.Write("Nota do terceiro trimestre: ");
            int terceiroTrimestre = int.Parse(Console.ReadLine());

            int media = (primeiroTrimestre * 30 + segundoTrimestre * 35 + terceiroTrimestre * 35) / 100;
            Console.WriteLine($"Aluno {nome} tirou {media}");

            if (media >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltam {0} para atingir 60 pontos", 60 - media);
            }
        }
    }
}
