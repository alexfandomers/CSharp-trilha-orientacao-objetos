using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Interface_Class17_18_
{
    public interface IPadrao
    {
        //Metodos(o padrao ja e public e abstract-nao preciso definir se e publico ou abstract)
        void somar(int n1, int n2);

        void subtrair(int n1, int n2);
    }
}