using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco)
        {
            id = id;
            Produto = produto;
            preco = preco;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
    }
}