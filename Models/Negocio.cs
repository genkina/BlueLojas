using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blueLojas.Models
{
    public class Negocio
    {
        public List<Produtos> listaProduto = new List<Produtos>();
        public void Produtos()
        {
            listaProduto.Add(new Produtos
            {
                id = 42,
                preco = 90,
                nome = "camisa",
                imagem = null
            });

        }
        public void adicionaProduto(Produtos produto) {
            listaProduto.Add(produto);
        }
        public void deletaProduto(int id)
        {
            foreach (var item in listaProduto)
            {
                if(item.id == id)
                {
                    listaProduto.Remove(item);
                    break;
                }

            }

        }

    }
}
