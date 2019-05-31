using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabainho_de_Poozinho.Códigos
{
    class Vendas
    {
        private double _ValorVenda;
        private double _Lucro;
        private string _Modelo;
        private string _Placa;
        private string _NCliente;
        private string _FormaPag;
        public double ValorVenda { get => _ValorVenda; set => _ValorVenda = value; }
        public double Lucro { get => _Lucro; set => _Lucro = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string NCliente { get => _NCliente; set => _NCliente = value; }
        public string FormaPag { get => _FormaPag; set => _FormaPag = value; }
    }
}
