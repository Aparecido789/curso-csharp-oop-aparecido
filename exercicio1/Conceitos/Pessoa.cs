using System;

namespace Conceitos
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        
        public void mensagem()
        {
            Console.WriteLine("Olá "+nome+" você tem "+idade+" anos");
        }
    }
}