using System;

//https://www.youtube.com/watch?v=dARHRw1d0qI&list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E&index=3
namespace ClassAttributesMethodsObjects
{
    //class
    public class Person
    {
        //Attributes
        public string name;
        public int Age;

        //Methods
        public void mensagem()
        {
            System.Console.WriteLine("Hello");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //object instance
            Person obj = new Person();
            obj.name = "Alexandre";
            obj.Age = 30;
            obj.mensagem();
            System.Console.WriteLine(obj.name);
        }
    }
}
