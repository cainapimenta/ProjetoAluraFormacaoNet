using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class BuscarProdutoViewModel
    {
        public IList<Produto> Produtos { get; }

        public string Pesquisa { get; }

        public BuscarProdutoViewModel(IList<Produto> produtos, string pesquisa)
        {
            Produtos = produtos;
            Pesquisa = pesquisa;
        }
    }
}
