using System;

//https://www.youtube.com/watch?v=OCRz0LnTlcY&list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E&index=10
//o encapsulamento evita de deixar atributos de maneira publica
//o get(pega valor) and set (envia valor) permite capturar e enviar uma informação de um atributo privado
//todo metodo get and set é publico.
namespace CSharpGetSetProperties
{
    class Pessoa
    {
        //Atributo
       private string nome;

       //Get e Set
       public string Nome
       {
            get{return nome;}
            set{nome=value;}//este valor o usuario vai me informar em outra classe
       }
    }
    public class Program
    {
        static void Main(string[] args)
        {
           Pessoa obj = new Pessoa();
           obj.Nome = "Alexandre"; //Set
           //System.Console.WriteLine(obj.Nome);

            string nome = obj.Nome;//Get
            System.Console.WriteLine(obj.Nome);
        }
    }
}
