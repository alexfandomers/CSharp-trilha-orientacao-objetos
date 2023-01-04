using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Construtores_Class9_
{
    public class Pessoa
    {
        //Construtor
        public Pessoa()
        {
            System.Console.WriteLine("Construtor executado");
        }

        public Pessoa(string nome)
        {
            System.Console.WriteLine("Olá " + nome);
        }

    }
}