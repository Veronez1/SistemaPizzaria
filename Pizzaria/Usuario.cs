using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Usuario
    {
        private int Id;
        public string Name;
        public string Cpf;

        public Usuario(string nome, string cpf)
        {
            this.Name = nome;
            this.Cpf = cpf;
            this.Id = Id++;
        }
    }
}
