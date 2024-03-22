using System;

namespace NotasAlunoOO
{
    public class Aluno
    {
        public float nota1, nota2, nota3;
        public string nome;

        public float Media
        {
            get
            {
                return (nota1 * 30 + nota2 * 35 + nota3 * 35) / 100;
            }
        }

        public Aluno(){
            nota1 = -1;
            nota2 = -1;
            nota3 = -1;
            nome = "";
        }

        public Aluno(string nome, float nota1, float nota2, float nota3) {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
    }
}
