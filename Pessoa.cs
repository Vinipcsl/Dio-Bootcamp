using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
           string Nome = "Vini";
            Console.WriteLine($"Olá, meu nome é {Nome} \n Tenho {Idade} anos");
        }
    }
}