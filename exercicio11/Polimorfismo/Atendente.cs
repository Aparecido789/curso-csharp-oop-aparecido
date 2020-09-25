using System;

namespace Polimorfismo
{
    class Atendente : Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto Atendente do Vale Alimentação R$"+(salario * 0.12));
        }
    }
}