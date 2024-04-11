using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            /*
            m.Cumprimentar();
            m.Somar(10, 9);
            m.Apresentar("Rodrigo", 25);

            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);
       
            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);
            Console.ReadKey();
            */

            /* string nomeCompleto = m.MontaNome("Rodrigo", "Abade");
             int codigoChar = m.CodigoChar('a');
             double PI = m.ValorPI();

             Console.WriteLine(nomeCompleto);
             Console.WriteLine(codigoChar);
             Console.WriteLine(PI); */


            m.Cumprimentar();
            m.Comprimentar("Rodrigo");
            m.Comprimentar("Rodrigo, 18");

            bool res1 = m.Comparar(100, 50 * 2);
            bool res2 =  m.Comparar("Rodrigo", "rodrigo");

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            
           
            Console.ReadKey();
        }        
    }
}
