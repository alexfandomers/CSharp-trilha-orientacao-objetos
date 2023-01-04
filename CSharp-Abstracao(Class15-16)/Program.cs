using System;

//https://www.youtube.com/watch?v=-ZsWYut9MVo&list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E&index=15
//Abstratact é uma classe que pode conter metodos obrigatorios para todas as classe que herdarem
//E possivel criar metodos convencionais(não obrigatórios) para que as classes que herdam consigam utilizar
//Não é possivel instanciar uma classe abstrata
//Padrao utilizado em projetos com muitos desenvolvedores, pois garante uma estrutura pre-moldada com ações que podem ser realizadas
//Como é utilizada a herança, cada classe pode herdar apenas uma classe abstrata;
//ex: class Produto : PadraoProduto (ok)
//    class Produto : PadraoProduto, CalculoImpostos(Falha)
namespace CSharp_Abstracao_Class15_16_
{
     public class Program
    {
        static void Main(string[] args)
        {  
           PessoaFisica pf = new PessoaFisica();
           pf.taxaEmprestimo(1000);

           PessoaJuridica pj = new PessoaJuridica();
           pj.taxaEmprestimo(1000);
        }
    }
}
            