using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObjetos
{
    internal class Pessoa
    {
        //Atributos / Campos
        public string Nome;
        public string Sobrenome;
        public int anoNascimento;

        public void Cumprimentar()
        {
            Console.WriteLine("Ola eu sou:" + Nome + " " + Sobrenome);
        }

    }
}
