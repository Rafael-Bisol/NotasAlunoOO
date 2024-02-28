using System;

namespace NotasAlunoOO
{
    public class Aluno
    {
        public int nota1, nota2, nota3;
        public string nome;

        public int Media()
        {
            return (nota1 * 30 + nota2 * 35 + nota3 * 35) / 100;
        }
    }
}
