using System;

namespace Polimorfismo
{
    class Gerente : Imposto
    {
        // Método

        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto Gerente do Vale Alimentação R$"+(salario * 0.15));
        }
    }
}