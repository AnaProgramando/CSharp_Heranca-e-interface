using CSharp_Heranca_e_interface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Heranca_e_interface
{
    class Program
    {
        static void Main(string[] args)
        {            
            Funcionario fulano = new Funcionario();
            fulano.Nome = "Fulano";
            fulano.CPF = "123.456.789-10";
            fulano.Salario = 2000;

            Console.WriteLine(fulano.Nome);
            Console.WriteLine(fulano.GetBonificacao());                  

            Console.ReadLine();
        }
    }
}
