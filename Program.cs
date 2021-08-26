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

            Funcionario fulano = new Funcionario("123.456.789-10");
            fulano.Nome = "Fulano";
            fulano.Salario = 2000;

            Console.WriteLine("Total de funcionários:  " + Funcionario.TotalFuncionarios);
            gerenciador.Registrar(fulano);

            Diretor beltrano = new Diretor("109.876.543-21");
            beltrano.Nome = "Beltrano";
            beltrano.Salario = 5000;

            Console.WriteLine("Total de funcionários:  " + Funcionario.TotalFuncionarios);
            gerenciador.Registrar(beltrano);

            Console.WriteLine("Nome: " + fulano.Nome);
            Console.WriteLine("Valor da bonificação: R$ " + fulano.GetBonificacao() + "\r\n");

            Console.WriteLine("Nome: " + beltrano.Nome);
            Console.WriteLine("Valor da bonificação: R$ " + beltrano.GetBonificacao() + "\r\n");

            Console.WriteLine("Total de bonificações: R$ " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
