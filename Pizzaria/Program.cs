using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pedido> pedidos = new List<Pedido>();
            List<Pizza> pizzas = new List<Pizza>();

            UI.menuTelaInicial();

            //Confirma se nome existe
            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();
            var ConfirmaNome = Validadores.validaNome(nome);

            Console.WriteLine("Digite seu CPF: ");
            var cpf = Console.ReadLine();
            var ConfirmaCpf = Validadores.validaCpf(cpf);

            var client = new Cliente(nome, cpf);
            Console.Clear();
            bool check = true;
            
            //Se validar o nome e o CPF vai rodar o restante do programa
            if (ConfirmaNome == true && ConfirmaCpf == true)
            {
                UI.menuCadastroRealizado();

                UI.menuNovoPedido();
                var indicadorParaCriarPedido = Console.ReadLine();
                check = indicadorParaCriarPedido == "s";

                while (check)
                {
                    var pizza = new Pizza();

                    UI.menuQualSabor();
                    pizza.sabor = Console.ReadLine();
                    UI.limpaTela();
                    
                    UI.menuQualTamanho();
                    pizza.tamanho = Console.ReadLine();
                    UI.limpaTela();
                    pizzas.Add(pizza);

                    var pedido = new Pedido(client, pizza);
                    pedidos.Add(pedido);
                    
                    UI.menuProcessando();
                    pizza.processarPizza(pizza);
                    UI.menuPedidoCriado();

                    UI.menuExtras();
                    pedido.extras(Console.ReadLine());
                    UI.limpaTela();

                    UI.menuOutroPedido();
                    if (Console.ReadLine() == "n") {
                        check = false;
                    }
                    else
                    {
                        check = true;
                        pedido.pizza.setIdUnico(pedido.pizza.getIdUnico() + 1);
                    }
                }

                UI.limpaTela();
                UI.DesejaExcluirUmPedido();
                string RemoverPedido = Console.ReadLine();
                UI.limpaTela();

                if (RemoverPedido == "s")
                {
                    Console.WriteLine("Qual pedido você deseja remover? (0) para o primeiro pedido/ (1) para o segundo pedido");
                    var NumeroPedido = int.Parse(Console.ReadLine());
                    pedidos.RemoveAt(NumeroPedido);
                }
                if (!pedidos.Any())
                {
                    Console.WriteLine("Pedido vazio!");
                    Console.ReadLine();
                }
                
                else
                {   //Calcula o Preço
                    var ValorTotal = pedidos.Select(Valor => Valor.pizza.getPreco()).Sum(Valor => Convert.ToInt32(Valor));
                    Console.WriteLine(client.nome + " Seu pedido foi finalizado\nO valor do pedido é R$ " + ValorTotal);
                    Console.WriteLine("\nDigite o valor a ser pago!");
                    int Pagamento = int.Parse(Console.ReadLine());
    
                    if( Pagamento == ValorTotal){
                        Console.WriteLine("PAGA!!");
                    }
                    else 
                    {                        
                        if (Pagamento<ValorTotal)
                        {
                            int ValorPendente = ValorTotal - Pagamento;
                            Console.WriteLine("\nPague o Valor restante de R$ " + ValorPendente);
                            Console.ReadLine();   
                            if (ValorPendente + Pagamento == ValorTotal)
                            {
                                Console.WriteLine("PAGA!");
                            }
                            
                        }
                    }


                    UI. NotaFiscal();
                    foreach (Pedido pedido in pedidos)
                    {
                        Console.WriteLine("Nome usuário: " + pedido.cliente.nome);
                        Console.WriteLine("CPF:          " + pedido.cliente.cpf);                       
                        Console.WriteLine("Sabor:        " + pedido.pizza.sabor);
                        Console.WriteLine("Tamanho:      " + pedido.pizza.tamanho);
                        Console.WriteLine("===========================");
                    }
                    Console.WriteLine("Status Nota:  PAGA!");
                    Console.WriteLine("Preço:        " + "R$" + ValorTotal);

                }
                if (ConfirmaNome == false || ConfirmaCpf == false)
                {
                    Console.Clear();
                    Console.WriteLine("Reinicie do sistema e tente novamente!");
                    Console.ReadLine();
                }
            }

        }
    }
}

