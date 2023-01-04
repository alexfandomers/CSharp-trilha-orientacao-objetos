using System;

//https://www.youtube.com/watch?v=xArbuUcIEBw&list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E&index=5
//Atributes, classes, methods and objects.
namespace CSharp_ObjectOriented_Class5_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //instanciar objeto da classe aluno
            Aluno a = new Aluno();
            a.nome = "Denis";
            a.nota1 = 10;
            a.nota2 = 9;
            a.mensagem();
        }
    }
}