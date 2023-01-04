using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//São a maneira que vc tem de visualizar um atributo ou método
/*
 public - atributos e metodos visiveis em qualquer classe
 private - atributos e metodos visiveis apenas na classe em que são criados
 protected - atributos e metodos visiveis em classes onde são criados herdados
*/
namespace CSharp_AccessModifiers_Class7_
{
    public class Produto
    {
        public string nome;
        private double valor;
    }
}