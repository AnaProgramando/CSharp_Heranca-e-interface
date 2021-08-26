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
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Coordenador fulano = new Coordenador("123.456.789-11");
            fulano.Nome = "Fulano";

            Diretor beltrano = new Diretor("123.456.789-22");
            beltrano.Nome = "Beltrano";

            Auxiliar sicrano = new Auxiliar("123.456.789-33");
            sicrano.Nome = "Sicrano";

            Gerente ana = new Gerente("123.456.789-44");
            ana.Nome = "Ana";

            gerenciadorBonificacao.Registrar(fulano);
            gerenciadorBonificacao.Registrar(beltrano);
            gerenciadorBonificacao.Registrar(sicrano);
            gerenciadorBonificacao.Registrar(ana);

            Console.WriteLine("Total de bonificações: R$ " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
