using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Pedido
    {
        private int idUnico;
        public Pizza pizza;
        public Cliente cliente;
        public string borda = "n";
        public string refrigerante = "n";

        public Pedido(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Pedido(Cliente cliente, Pizza pizza)
        {
            this.idUnico = idUnico++;
            this.pizza = pizza;
            this.cliente = cliente;
        }

        public void extras(string extras)
        {
            if (extras == "s")
            {
                UI.menuExtraBorda();

                if (Console.ReadLine() == "s")
                {
                    pizza.setPreco(pizza.getPreco() + 5);
                    borda = "s";
                }

                UI.limpaTela();

                UI.menuExtraRefrigerante();
                if (Console.ReadLine() == "s")
                {
                    pizza.setPreco(pizza.getPreco() + 10);
                    refrigerante = "s";
                }
                UI.limpaTela();
            }
        }

    }
}

