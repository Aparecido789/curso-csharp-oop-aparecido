using System;

namespace ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa eu = new Pessoa();
            eu.altura = 1.80;
            eu.peso = 60.00;
            eu.mensagem();
        }
    }
}
