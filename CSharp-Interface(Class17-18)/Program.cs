using System;

//https://www.youtube.com/watch?v=3rESp2ft5SM&list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E&index=17
//Utilizada para criar exclusivamente metodos obrigatorios
//Uma classe pode implementar várias interfaces
//Os metodos da interface nao contem calculos, condicionais, laços e demais açoes;
//ex: double calculo(double numero); (nao utilizamos a regra aqui, ela e inserida na classe que implementa a interface)
//    string texto(); (nao utilizamos a regra aqui, ela e inserida na classe que implementa a interface)
//    void mensagem(string nome, int idade); (nao utilizamos a regra aqui, ela e inserida na classe que implementa a interface)
//No C# por padrao um metodo criado na Interface é abstrato e publico
//Vc não define como por exemplo: (public abstract void mensagem();) como na abstração
//Nas boas praticas toda interface tem inicial i, em seguida o nome da interface, ex:
//IPadrao; ICalculo; IConsulta; IAcoes
namespace CSharp_Interface_Class17_18_
{
    public class Program
    {
        static void Main(string[] args)
        {
           //Instanciar objeto e chamar os 2 metodos
           Calculo c = new Calculo();
           c.somar(10, 15);
           c.subtrair(50, 18);

        }
    }
}
