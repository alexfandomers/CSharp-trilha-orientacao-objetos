using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Abstracao_Class15_16_
{
    abstract class Padrao
    {
        //Metodo obrigatorio
        public abstract void taxaEmprestimo(double valor);

        //Metodo opcional
        public void calculoPoupanca(double valor, double taxa)
        {
            System.Console.WriteLine("Ganhos obtidos poupança R$ " + (valor * taxa));
        }
    }
}