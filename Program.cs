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

            Funcionario fulano = new Funcionario();
            fulano.Nome = "Fulano";
            fulano.CPF = "123.456.789-10";
            fulano.Salario = 2000;

            gerenciador.Registrar(fulano);

            Diretor beltrano = new Diretor();
            beltrano.Nome = "Beltrano";
            beltrano.CPF = "109.876.543-21";
            beltrano.Salario = 5000;

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
