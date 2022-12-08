using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var Refrigerante = "";
            var Borda = "";
            var sabor = "";
            var tamanho = "";
            List<Pedido> pedidos = new List<Pedido>();
            //Tela inicial
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===============================================================");
            Console.WriteLine("======= Bem vindo a Pizzaria do Davi Veronez e do Carlos ======");
            Console.WriteLine("===============================================================\n");
            Console.WriteLine("\n            [Pressione Enter para Continuar]\n");
            Console.ReadLine();
            Console.Clear();

            //Confirma se nome existe
            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();
            var ConfirmaNome = Validadores.ValidaNome(nome);

            Console.WriteLine("Digite seu CPF: ");
            var cpf = Console.ReadLine();
            var ConfirmaCpf = Validadores.ValidaCpf(cpf);

            var client = new Usuario(nome, cpf);
            Console.Clear();
            bool check = true;
            var pedido = new Pedido(client);

            //Se validar o nome e o CPF vai rodar o restante do programa
            if (ConfirmaNome == true && ConfirmaCpf == true)
            {
                Console.WriteLine("Cadastro realizado com sucesso!");

                Console.WriteLine("Gostaria de fazer um pedido? Digite (s) para sim e (n) para não");
                var CriarPedido = Console.ReadLine();
                if (CriarPedido == "s")
                {
                    check = true;
                }
                else if (CriarPedido == "n")
                {
                    check = false;
                }
                while (check == true)
                {
                    Console.WriteLine("Qual será o sabor da pizza?");
                    sabor = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Qual será o tamanho? (p) = Pequena / (m) = Média / (g) = Grande\n");
                    Console.WriteLine("Os valores por tamanho são Pequena = + R$ 15\n");
                    Console.WriteLine("Os valores por tamanho são Média = + R$ 20\n");
                    Console.WriteLine("Os valores por tamanho são Grande = + R$ 30\n");
                    tamanho = Console.ReadLine();
                    Console.Clear();
                    pedido = new Pedido(client, sabor, tamanho);
                    pedidos.Add(pedido);

                    Console.WriteLine("Processando o pedido...\n");
                    Thread.Sleep(1300);
                    Console.WriteLine("==============================\n");
                    pedido.ProcessarPedido();


                    Console.WriteLine("\nGostaria de um Extra?\n");
                    Console.WriteLine("Nossas opções são refrigerante e a borda da pizza extra\n");
                    Console.WriteLine("Digite (s) para sim e (n) para não\n");
                    var Extra = Console.ReadLine();
                    Console.Clear();
                    if (Extra == "s")
                    {
                        Console.WriteLine("O valor da borda é R$ 5,00");
                        Console.WriteLine("\nDigite (s) para confirmar e (n) para recusar\n");
                        Borda = Console.ReadLine();
                        Console.Clear();
                        if (Borda == "s")
                        {
                            var preco = pedido.PegaPreco() + 5;
                            pedido.Preco = preco;
                        }
                        Console.WriteLine("O valor do refrigerante é R$ 10,00");
                        Console.WriteLine("\nDigite (s) para confirmar e (n) para recusar\n");
                        Refrigerante = Console.ReadLine();
                        Console.Clear();
                        if (Refrigerante == "s")
                        {
                            var preco = pedido.PegaPreco() + 10;
                            pedido.Preco = preco;

                        }
                    }

                    if (Extra == "n")
                    {

                    }
                    Console.WriteLine("Gostaria de fazer outro pedido?");
                    Console.WriteLine("\nDigite (s) para sim e (n) para não");
                    CriarPedido = Console.ReadLine();
                    if (CriarPedido == "n")
                    {
                        check = false;
                        break;
                    }
                    check = true;
                }
                Console.Clear();

                Console.WriteLine("Deseja excluir um pedido?\n");
                Console.WriteLine("\nDigite (s) para sim e (n) para não");
                string RemoverPedido = Console.ReadLine();
                Console.Clear();

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
                    var ValorTotal = pedidos.Select(Valor => Valor.Preco).Sum(Valor => Convert.ToInt32(Valor));
                    Console.WriteLine(client.Name + " Seu pedido foi finalizado\nO valor do pedido é R$ " + ValorTotal);
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
                    Random random = new System.Random();
                    if (Borda == "s") { Borda = "Adicionada!"; };
                    if (Borda == "n") { Borda = "Não foi adicionado!"; };
                    if (Refrigerante == "s") { Refrigerante = "Adicionado!"; };
                    if (Refrigerante == "n") { Refrigerante = "Não foi adicionado!"; };
                    if (tamanho == "p") { tamanho = "Pequeno"; };
                    if (tamanho == "m") { tamanho = "Médio"; };
                    if (tamanho == "g") { tamanho = "Grande"; };
                    Console.WriteLine("\nAproveite a Pizza! E volte sempre");
                    Console.WriteLine("===========================");
                    Console.WriteLine("======= Notal Fiscal ======");
                    Console.WriteLine("===========================");
                    Console.WriteLine("Nome usuário: " + nome);
                    Console.WriteLine("CPF:          " + cpf);
                    Console.WriteLine("Preço:        " +"R$"+ ValorTotal); 
                    Console.WriteLine("Borda:        " + Borda); 
                    Console.WriteLine("Refrigerante: " + Refrigerante); 
                    Console.WriteLine("Sabor:        " + sabor);
                    Console.WriteLine("Tamanho:      " + tamanho); 
                    Console.WriteLine("Status Nota:  PAGA!");
                    Console.ReadLine();
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

