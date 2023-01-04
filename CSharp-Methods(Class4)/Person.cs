using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Methods_Class4_
{
    public class Person
    {
        //method-1
        public void apresentar()
        {
            System.Console.WriteLine("Hello");
        }
        //method-2
        public void apresentar(string name)
        {
            System.Console.WriteLine("Olá " + name);
        }
        //method-3
        public void apresentar(string name, int age)
        {
            System.Console.WriteLine("Hello " + name + " you are" + age + " anos");
        }
    }
}