using System;

//https://www.youtube.com/watch?v=69v1RXUFawc&list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E&index=14
//Sempre que executamos um metodo(ação) instanciamos o objeto
//nem sempre e necessario instanciar um objeto, podemos deixá-lo a disposição sem ter que instancia-lo
namespace CSharp_Atributos_e_metodos_estaticos_Class14_
{
    public class Program
    {
        static void Main(string[] args)
        {
           Exemplo.soma(3, 7);

           System.Console.WriteLine("Olá " + Exemplo.nome);
        }
    }
}