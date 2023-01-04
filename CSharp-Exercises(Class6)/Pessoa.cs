using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Exercises_Class6_
{
    public class Pessoa
    {
        //atributos
        public double peso, altura;

        //imc
        public double imc()
        {
            return peso / (altura*altura);
        }

        //situacao
        public string situacao(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if(imc > 18.5 && imc < 25)
            {
                return "Peso normal";
            }
            else if(imc > 25 && imc < 30)
            {
                return "acima d peso";
            }
            else if(imc > 30 && imc < 35)
            {
                return "Obesidade I";
            }
            else if(imc > 35 && imc < 40)
            {
                return "Obesidade II";
            }
            else
            {
                return "Obesidade III";
            }
        }
        //Mensagem
        public void mensagem()
        {
            double obterImc = imc();
            string obterSituacao = situacao(obterImc);
            System.Console.WriteLine("Seu IMC é " + obterImc + " o seu status é: " + obterSituacao);
        }
    }
}