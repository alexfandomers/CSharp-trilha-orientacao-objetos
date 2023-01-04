using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Abstracao_Class15_16_
{
     class PessoaFisica : Padrao
    {
        //Metodo obrigatorio
        public override void taxaEmprestimo(double valor)
        {
            System.Console.WriteLine("Taxa de emprestimo para pessoa fisica R$ "+(valor *0.1));
        }
    }
}