using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Produto
    {
        public string Descricao { get; set; }
        public int Codigo { get; set; }
        public double Preco { get; set; }
        public double Total { get; set; } = 0;

        public double CalculaProduto(double preco, int quantia)
        {
            return Total += preco * quantia;
        }

        public override string ToString()
        {
            return $"|{Descricao}\t|{Codigo}|\t{Preco}";
        }
    }
}
