using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Pedido
    {
        public static int id = 0;
        private int idUnico;
        public string Sabor;
        public string Tamanho;
        public int Preco;
        public Usuario Usuario;

        public Pedido(Usuario usuario)
        {
            this.Usuario = usuario;
        }
        public Pedido(Usuario usuario, string sabor, string tamanho)
        {
            this.idUnico = idUnico++;

            this.Sabor = sabor;
            this.Tamanho = tamanho;
            this.Usuario = usuario;
        }

        public void ProcessarPedido()
        {
            if (Tamanho == "p")
            {
                this.Preco = 15;
            }           
            if (Tamanho == "m")
            {
                this.Preco = 20;
            }
            if (Tamanho == "g")
            {
                this.Preco = 30;
            }
            Console.WriteLine("Pedido criado com sucesso!");
        }

        public int PegaPreco()
        {
            return this.Preco;
        }

    }
}

