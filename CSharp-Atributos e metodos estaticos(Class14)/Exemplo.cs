using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Atributos_e_metodos_estaticos_Class14_
{
    public class Exemplo
    {
        //Atributo estatico
        public static string nome = "Ralf";

        //Metodo estático(vou ter acesso ao metodo "soma sem ter que estanciar o objeto)
        public static void soma(int n1, int n2)
        {
            System.Console.WriteLine(n1 + n2);
        }
    }
}