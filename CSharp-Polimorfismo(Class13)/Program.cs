using System;

//https://www.youtube.com/watch?v=JjIqcPyVO0o&list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E&index=13
namespace CSharp_Polimorfismo_Class13_
{
    public class Program
    {
        static void Main(string[] args)
        {
           //Instanciar estagiario
           Imposto objetoEstagiario = new Estagiario();
           objetoEstagiario.valeAlimentacao(1000);
           objetoEstagiario.valeTransporte(1000);
           System.Console.WriteLine("------------------");

           //Instanciar Gerente
           Imposto objetoGerente = new Gerente();
           objetoGerente.valeAlimentacao(5000);
           objetoGerente.valeTransporte(5000);
           System.Console.WriteLine("----------------");

           //Instanciar Atendente
           Imposto objetoAtendente = new Atendente();
           objetoAtendente.valeAlimentacao(2000);
           objetoAtendente.valeTransporte(2000);
        }
    }
}