using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class UI
    {

        public static void menuPrincipal()
        {

        }

        public static void limpaTela()
        {
            Console.Clear();
        }

        public static void menuTelaInicial() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===============================================================");
            Console.WriteLine("======= Bem vindo a Pizzaria do Davi Veronez e do Carlos ======");
            Console.WriteLine("===============================================================\n");
            Console.WriteLine("\n            [Pressione Enter para Continuar]\n");
            Console.ReadLine();
            Console.Clear();
        }

        public static void menuCadastroRealizado() 
        {
            Console.WriteLine("Cadastro realizado com sucesso!\n\n");
        }

        public static void menuNovoPedido()
        { 
            Console.WriteLine("Gostaria de fazer um pedido? \n\nDigite (s) para sim e (n) para não");
        }

        public static void menuQualSabor() 
        {
            Console.WriteLine("Qual será o sabor da pizza?"); 
        }

        public static void menuQualTamanho() 
        {
            Console.WriteLine("Qual será o tamanho? \n\n");
            Console.WriteLine("+----------+-----------+----------+");
            Console.WriteLine("|  DIGITE  |  TAMANHO  |  PREÇO   |");
            Console.WriteLine("+----------+-----------+----------+");
            Console.WriteLine("|    p     | Pequena   | R$ 15,00 |");
            Console.WriteLine("|    m     | Média     | R$ 20,00 |");
            Console.WriteLine("|    g     | Grande    | R$ 30,00 |");
            Console.WriteLine("+----------+-----------+----------+");
            Console.WriteLine("\n\nDigite");
        }

        public static void menuProcessando()
        {
            Console.WriteLine("Processando o pedido...\n");
            Thread.Sleep(1300);
            Console.WriteLine("==============================");
        }

        public static void menuPedidoCriado() 
        {
            Console.WriteLine("Pedido criado com sucesso!");
            Console.WriteLine("==============================");
        }

        public static void menuExtras()
        {
            Console.WriteLine("\nGostaria de um Extra?\n");
            Console.WriteLine("Nossas opções são Refrigerante e a Borda da pizza extra\n");
            Console.WriteLine("Digite (s) para sim e (n) para não\n");
        }

        public static void menuExtraBorda()
        {
            Console.WriteLine("O valor da borda é R$ 5,00");
            Console.WriteLine("\nDigite (s) para confirmar e (n) para recusar\n");
        }

        public static void menuExtraRefrigerante()
        {
            Console.WriteLine("O valor do refrigerante é R$ 10,00");
            Console.WriteLine("\nDigite (s) para confirmar e (n) para recusar\n");
        }

        public static void menuOutroPedido() 
        {
            Console.WriteLine("Gostaria de fazer outro pedido?");
            Console.WriteLine("\nDigite (s) para sim e (n) para não");
        }

        public static void DesejaExcluirUmPedido()
        {
            Console.WriteLine("Deseja excluir um pedido?\n");
            Console.WriteLine("\nDigite (s) para sim e (n) para não");
        }


        public static void NotaFiscal()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("======= Notal Fiscal ======");
            Console.WriteLine("===========================");
        }

    }
}
