using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Validadores
    {
        public static bool ValidaNome(string nome)
        {
            if (nome == string.Empty)
            {
                Console.Write("Não são aceitos nomes vazios!");
                Console.ReadLine();
                return false;
            }
            return true;
        }
        public static bool ValidaCpf(string cpf)
        {
            if (cpf == null)
            {
                Console.WriteLine("Insira um CPF!");
                Console.ReadLine();
                return false;
            }
            if (cpf.Length < 11)
            {
                Console.WriteLine("Esse CPF não é valido, por favor insira um CPF existente!\n");
                Console.WriteLine("Limite de tentativas de cadastro atingido, reinicie o sistema e insira um Nome/CPF valido!");
                Console.ReadLine();
                return false;
            }
            return true;
        }
    }
}
