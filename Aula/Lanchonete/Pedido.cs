using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Pedido : Cliente
    {
        public List<Produto> pedido = new List<Produto>();

        public void AddProdutos(List<Produto> pedido)
        {

        }
    }
}
