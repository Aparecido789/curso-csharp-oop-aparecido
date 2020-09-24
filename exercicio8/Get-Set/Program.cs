using System;

namespace Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.Nome = "Aparecido";
            Console.WriteLine(p.Nome);
        }
    }
}
