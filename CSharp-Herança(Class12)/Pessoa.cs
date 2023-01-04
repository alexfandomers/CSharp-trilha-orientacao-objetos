using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Herança_Class12_
{
    public class Pessoa
    {
        //Atributos
        //protected: somente a classe e a herança tem acesso
        protected string nome;
        protected int idade;

        protected void mensagemPessoa()
        {
            System.Console.WriteLine("Nome: " + nome);
            System.Console.WriteLine("Idae: " + idade);
        }
    }
}