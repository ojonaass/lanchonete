using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] Produtos = new Produto[6];

            Produtos[0] = new Produto { Codigo = 100, Descricao = "Hot-Dog", Preco = 1.8 };
            Produtos[1] = new Produto { Codigo = 101, Descricao = "Bauru Simples", Preco = 2.3 };
            Produtos[2] = new Produto { Codigo = 102, Descricao = "Bauru com Ovo", Preco = 2.8 };
            Produtos[3] = new Produto { Codigo = 103, Descricao = "Hambuguer", Preco = 2.5 };
            Produtos[4] = new Produto { Codigo = 104, Descricao = "Suco\t", Preco = 3.5 };
            Produtos[5] = new Produto { Codigo = 105, Descricao = "Refrigerante", Preco = 1.75 };

            foreach (var item in Produtos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDigite o código do pedido: ");
            int codigoPedido = int.Parse(Console.ReadLine());


            Console.WriteLine("\nDigite a Quantidade do pedido: ");
            int quantidadePedido = int.Parse(Console.ReadLine());
            foreach (var item in Produtos)
            {
                if (item.Codigo == codigoPedido)
                {
                    item.CalculaProduto(item.Preco, quantidadePedido);

                    Console.WriteLine($"Total: {item.Total}");
                }
            }
        }
    }
}
