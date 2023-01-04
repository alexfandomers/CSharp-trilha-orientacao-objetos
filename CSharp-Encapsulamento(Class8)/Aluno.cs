using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//restringe acesso a informações que temos nas classes
namespace CSharp_Encapsulamento_Class8_
{
    public class Aluno
    {
        //atributos
        private double nota1, nota2;

        //Metodo - media
        private double media()
        {
            return (nota1+nota2)/2;
        }

        //mensagem
        public void mensagem()
        {
            System.Console.WriteLine("Informe nota");
            nota1=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Informe nota");
            nota2=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("A média é " + media());
        }
    }
}