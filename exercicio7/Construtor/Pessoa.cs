using System;

namespace Construtor
{
    class Pessoa
    {
        //Construtor

        public Pessoa()
        {
            Console.WriteLine("Construtor Executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Olá "+nome);
        }

    }
}