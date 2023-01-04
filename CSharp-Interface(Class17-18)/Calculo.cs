using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Interface_Class17_18_
{
    public class Calculo : IPadrao //implementando IPadrao
    {
        public void somar(int n1, int n2)
        {
           System.Console.WriteLine( "A soma é "+ (n1+n2));
        }

        public void subtrair(int n1, int n2)
        {
           System.Console.WriteLine( "A subtração é " + (n1-n2));
        }
    }
}