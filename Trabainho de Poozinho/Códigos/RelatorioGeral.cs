using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabainho_de_Poozinho.Códigos
{
    class RelatorioGeral
    {
        //pega o valor da venda e subtrai pelo valor de compra do veiculo;
        private double _LucroFinal,_ValorCompra,_ValorVenda;

        //veiculos comprados e vendas
        private string _VeiculoComprado,_VeiculoVendido;
        public double LucroFinal { get => LucroFinal; set => LucroFinal = value; }
        public double ValorCompra { get => ValorCompra; set => ValorCompra = value; }
        public double ValorVenda { get => ValorVenda; set => ValorVenda = value; }
        public string VeiculoComprado { get => _VeiculoComprado; set => _VeiculoComprado = value; }
        public string VeiculoVendido { get => _VeiculoVendido; set => _VeiculoVendido = value; }
    }
}
