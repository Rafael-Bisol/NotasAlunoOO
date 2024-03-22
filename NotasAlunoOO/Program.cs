using System;

namespace NotasAlunoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float nota1, nota2, nota3;

            Console.WriteLine("Notas do Aluno");
            Console.Write("Nome do Aluno: ");
            nome = Console.ReadLine();
            Console.Write("Nota do primeiro trimestre: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Nota do segundo trimestre: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Nota do terceiro trimestre: ");
            nota3 = float.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);

            if (aluno.nome == "" || nota1 < 0 || nota2 < 0 || nota3 < 0) {
                Console.WriteLine("Você deixou algum campo em branco ou pôs um valor errado.\n",
                    "Ai, ai ai! O que eu faço com você!\n",
                    "Você causou um erro. Agora sai daqui, palhaço!!");
                return;
            }

            Console.WriteLine($"Aluno {aluno.nome} tirou {aluno.Media}");

            if (aluno.Media >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltam {0} para atingir 60 pontos", 60 - aluno.Media);
            }
        }
    }
}
