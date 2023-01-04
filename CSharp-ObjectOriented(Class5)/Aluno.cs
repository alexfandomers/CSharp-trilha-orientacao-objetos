using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ObjectOriented_Class5_
{
    public class Aluno
    {
        //Atributos
        public string nome;
        public double nota1, nota2;

        //////Metodos/////
        //Media
        public double media()
        {
            return (nota1+nota2)/2;
        }

        //Situação
        public string situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }

        //Mensagem
        public void mensagem()
        {
            //obter media
            double obterMedia = media();

            //obter situacao
            string obterSitucao = situacao(obterMedia);

            //mensagem
            System.Console.WriteLine(nome + " esta" + obterSitucao + "com media" + obterMedia);
        }


    }
}