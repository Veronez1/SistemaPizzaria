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
        public Pizza pizza;
        public Cliente cliente;
        public string borda;

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

                borda = Console.ReadLine();
                if ( borda == "s")
                    pizza.setPreco(pizza.getPreco() + 5);
                UI.limpaTela();

                UI.menuExtraRefrigerante();
                if (Console.ReadLine() == "s")
                    pizza.setPreco(pizza.getPreco() + 10);
                UI.limpaTela();
            }
        }

    }
}

