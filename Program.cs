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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario fulano = new Funcionario(2000, "123.456.789-10");
            fulano.Nome = "Fulano";

            Console.WriteLine("Total de funcionários:  " + Funcionario.TotalFuncionarios + "\r\n");

            gerenciador.Registrar(fulano);

            Diretor beltrano = new Diretor("109.876.543-21");
            beltrano.Nome = "Beltrano";
                      
            Console.WriteLine("Total de funcionários:  " + Funcionario.TotalFuncionarios + "\r\n");
                 
            gerenciador.Registrar(beltrano);

            Console.WriteLine("Nome: " + fulano.Nome);
            Console.WriteLine("Valor da bonificação: R$ " + fulano.GetBonificacao());
            Console.WriteLine("Valor do salário: R$ " + fulano.Salario);

            fulano.AumentarSalario();
            Console.WriteLine("Salário com aumento: R$ " + fulano.Salario + "\r\n");


            Console.WriteLine("Nome: " + beltrano.Nome);
            Console.WriteLine("Valor da bonificação: R$ " + beltrano.GetBonificacao());
            Console.WriteLine("Valor do salário: R$ " + beltrano.Salario);

            beltrano.AumentarSalario();
            Console.WriteLine("Salário com aumento: R$ " + beltrano.Salario + "\r\n");

            Console.WriteLine("Total de bonificações: R$ " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
