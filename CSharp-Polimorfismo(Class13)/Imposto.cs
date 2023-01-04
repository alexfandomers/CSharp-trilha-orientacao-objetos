using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Polimorfismo_Class13_
{
    public class Imposto
    {
        //Metodos
        //atendente e gerente estão sobescrevendo o metodo de vale alimentação
        //devemos acrescentar "virtual" antes do void para que isso possa ocorrer
        //na class gerente e atendente acrescentamos "override" antes do void
        public virtual void valeAlimentacao(double salario)
        {
             System.Console.WriteLine("Desconto padrao alimentação R$ " + (salario * 0.1));
        }

        public void valeTransporte(double salario)
        {
            System.Console.WriteLine("Desconto padrao transporte R$" + (salario * 0.06));
        }
           
        
    }
}