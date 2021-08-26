using CSharp_Heranca_e_interface.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Heranca_e_interface.Funcionarios
{
    public class Diretor : Funcionario, Autenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            //O CPF é recebido no construtor de Diretor(), e ao chamar o construtor da classe base, passa o argumento cpf. 
        }

        public bool Autenticar(string senha)
        {
            return true;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
            // É o mesmo que fazer: Salario = Salario + (Salario * 0.15)
            // É o mesmo que fazer: Salario = * 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
