using System;

namespace Abstracao
{
    abstract class Padrao
    {
        // Obrigatório

        public abstract void taxaEmprestimo(double valor);

        // Opcional        
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança R$ "+(valor * taxa));
        }

    }
}