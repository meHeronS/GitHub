using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabainho_de_Poozinho.Códigos
{
    class RelatorioVendas
    {
        private string modelo, cliente, valor, pagamento;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Pagamento { get => pagamento; set => pagamento = value; }
    }
}
