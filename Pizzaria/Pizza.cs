using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Pizza
    {
        public string sabor;
        public string tamanho;
        public int preco;
        private int idUnico;

        public Pizza() { this.idUnico = idUnico++; }

        public void processarPizza(Pizza pizza)
        {
            switch (pizza.tamanho)
            {
                case "p":
                    this.preco = 15;
                    break;
                case "m":
                    this.preco = 20;
                    break;
                case "g":
                    this.preco = 30;
                    break;
            }
        }

        public int getPreco()
        {
            return this.preco;
        }

        public void setPreco(int preco)
        {
            this.preco = preco;
        }

        public int getIdUnico()
        {
            return this.idUnico;
        }

        public void setIdUnico(int idUnico)
        {
            this.idUnico = idUnico;
        }
    }
}
