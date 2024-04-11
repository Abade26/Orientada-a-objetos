using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClasseObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Ramon";
            p1.Sobrenome = "Robert";
            p1.anoNascimento = 2000;

            Pessoa p2 = new Pessoa()
            {
                Nome = "Rodrigo",
                Sobrenome = "Abade",
                anoNascimento = 1998
            };

            

            Console.WriteLine("Pessoa 1: " + p1.Nome);
            Console.WriteLine("Pessoa 1: " + p1.Sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa 2: " + p2.Nome);
            Console.WriteLine("Pessoa 2: " + p2.Sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);
            p2.Cumprimentar();
            

            Console.ReadKey();


        }
    }
    class MyClass
    {

    }
}
