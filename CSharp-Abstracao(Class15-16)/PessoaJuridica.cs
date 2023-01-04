using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Abstracao_Class15_16_
{
     class PessoaJuridica : Padrao
    {
        //Método obrigatório
        public override void taxaEmprestimo(double valor)
        {
           System.Console.WriteLine( "Taxa de empréstimo para Pessoa Jurídica R$ "+(valor * 0.2));
        }
    }
}