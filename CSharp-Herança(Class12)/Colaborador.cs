using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Herança_Class12_
{
    public class Colaborador : Pessoa
    {
        //atributo
        private double salario;

        //Construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            mensagemPessoa();
            mensagemColaborador();
        }

        //Metodo
        private void mensagemColaborador()
        {
            System.Console.WriteLine("Salario: " + salario);
        }
    }
}