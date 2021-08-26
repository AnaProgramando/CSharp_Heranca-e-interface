using CSharp_Heranca_e_interface.Funcionarios;
using CSharp_Heranca_e_interface.Sistemas;
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
            // CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor beltrano = new Diretor("123.456.789-22");
            beltrano.Nome = "Beltrano";
            beltrano.Senha = "123";
                     
            Gerente ana = new Gerente("123.456.789-44");
            ana.Nome = "Ana";
            ana.Senha = "321";

            sistemaInterno.Logar(beltrano, "123");
            sistemaInterno.Logar(ana, "321");
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

            Desenvolvedor beatriz = new Desenvolvedor("123.456.789-55");
            beatriz.Nome = "Beatriz";

            gerenciadorBonificacao.Registrar(fulano);
            gerenciadorBonificacao.Registrar(beltrano);
            gerenciadorBonificacao.Registrar(sicrano);
            gerenciadorBonificacao.Registrar(ana);
            gerenciadorBonificacao.Registrar(beatriz);

            Console.WriteLine("Total de bonificações: R$ " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
