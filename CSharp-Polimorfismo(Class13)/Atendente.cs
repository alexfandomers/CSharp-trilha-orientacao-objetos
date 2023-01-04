using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Polimorfismo_Class13_
{
    public class Atendente : Imposto
    {
        //Metodo
        public override void valeAlimentacao(double salario)
        {
            System.Console.WriteLine("Desconto atendente alimentaçao R$" + (salario*0.12));
        }
    }
}