using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blueLojas.Models
{
    public class Produtos
    {
        public int id { get; set; }
        public decimal preco { get; set; }
        public string nome { get; set; }
        public byte[] imagem { get; set; }
    }
}
