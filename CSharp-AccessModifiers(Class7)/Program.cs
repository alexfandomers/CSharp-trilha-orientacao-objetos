using System;

//https://www.youtube.com/watch?v=qBuDyaTFvlQ&list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E&index=7
//São a maneira que vc tem de visualizar um atributo ou metodo
namespace CSharp_AccessModifiers_Class7_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto obj = new Produto();
            obj.nome = "Eliot";
            System.Console.WriteLine(obj.nome);
        }
    }
}
