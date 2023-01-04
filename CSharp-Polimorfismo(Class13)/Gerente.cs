using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Polimorfismo_Class13_
{
    public class Gerente : Imposto
    {
        //Metodo
        public override void valeAlimentacao(double salario)
        {
             System.Console.WriteLine("Desconto gerente alimentação R$ " + (salario * 0.15));
        }
    }
}