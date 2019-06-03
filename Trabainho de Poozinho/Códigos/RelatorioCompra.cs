using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabainho_de_Poozinho.Códigos
{
    class RelatorioCompra
    {
        private string modelo, ano, placa, cor;
        private double _Valorcompra, _ValorVenda;
        public string Modelo { get => modelo; set => modelo = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Cor { get => cor; set => cor = value; }
        public double Valorcompra1 { get => _Valorcompra; set => _Valorcompra = value; }
        public double ValorVenda1 { get => _ValorVenda; set => _ValorVenda = value; }
    }
}
