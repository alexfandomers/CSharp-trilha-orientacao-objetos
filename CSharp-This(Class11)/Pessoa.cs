using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_This_Class11_
{
    public class Pessoa
    {
        //Atributo
        private string nome = "Tatiana";

        //Construtor
        public Pessoa(string nome)
        {
            System.Console.WriteLine("Referenciando o parametro " + nome);//aqui eu referencio o parametro
            System.Console.WriteLine("Referenciando o atributo " + this.nome); //com this eu referencio o atributo ("Tatiana")
        }
    }
}