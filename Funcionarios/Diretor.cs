using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Heranca_e_interface.Funcionarios
{
    public class Diretor : Funcionario
    {        
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Aqui chamo o CPF");
        }

        public override double GetBonificacao()
        {
            return Salario + base. GetBonificacao();
        }
    }
}
