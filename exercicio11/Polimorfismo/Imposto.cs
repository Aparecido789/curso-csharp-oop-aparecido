using System;

namespace Polimorfismo
{
    class Imposto
    {
        
        // Métodos
        public virtual void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto Padrão do Vale Alimentação R$"+(salario * 0.1));
        }

        public void valeTransporte(double salario)
        {
            Console.WriteLine("Desconto Padrão do Vale Transporte R$"+(salario * 0.06));
        }



    }
}