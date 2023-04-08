using CSharp_Heranca_e_interface.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Heranca_e_interface
{
    class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
