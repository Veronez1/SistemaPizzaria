using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Cliente
    {
        private int id;
        public string nome;
        public string cpf;

        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.id = id++;
        }

    }
}
