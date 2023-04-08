using CSharp_Heranca_e_interface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Heranca_e_interface.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
