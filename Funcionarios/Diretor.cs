using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Heranca_e_interface.Funcionarios
{
    public class Diretor : Funcionario
    {        
        public double GetBonificacao()
        {
            return Salario;
        }
    }
}
