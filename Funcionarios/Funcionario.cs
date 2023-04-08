using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Heranca_e_interface.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            
            //A propriedade Salário é igual ao argumento salário do construtor 
            Salario = salario;

            TotalFuncionarios++;
        }

        // Necessário sobrescrever o método AumentarSalario, pois cada cargo tem uma regra específica
        public abstract void AumentarSalario();

        // Necessário sobrescrever o método GetBonificacao, pois cada cargo tem uma regra específica
        public abstract double GetBonificacao();
    }
}
