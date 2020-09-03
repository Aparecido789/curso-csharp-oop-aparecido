using System;

namespace ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "Dênis";
            a.nota1 = 8;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}
