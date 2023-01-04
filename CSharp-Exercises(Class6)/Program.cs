using System;

//https://www.youtube.com/watch?v=MezRH7djLPo&list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E&index=6
//Exercicio:
//Criar classe pessoa e adicionar atributos: peso e altura.
//Criar método para retornar IMC, será um método double com calculo: peso / (altura* altura)
//criar um metodo para retornar uma string dependendo do IMC:
//<18.5 abaixo do peso; <25 peso normal; <30 acima do peso; <35 obesidade1; <40 obesidade2; >=40 obesidade3
//Criar metodo de mensagem para exibir o calculo e a situação
//Instanciar um objeto na classe program
namespace CSharp_Exercises_Class6_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.peso = 91;
            obj.altura = 1.82;
            obj.mensagem();
        }
    }
}