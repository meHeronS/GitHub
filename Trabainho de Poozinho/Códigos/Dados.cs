using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabainho_de_Poozinho.Códigos
{
    class Dados : ConcessionáriaProgram

    {
        private ArrayList _LClientes;
        private ArrayList _LVeiculos;
        private ArrayList _LVendas;
        private ArrayList _LCompras;
        private ArrayList _LGeral;
        public Dados()
        {
            _LVeiculos = new ArrayList();
            _LClientes = new ArrayList();
            _LVendas = new ArrayList();
            _LCompras = new ArrayList();
            _LGeral = new ArrayList();
        }
        public void _AdicionarVeiculo(Veiculo x)
        {
            _LVeiculos.Add(x);
        }

        public void _AlterarVeiculo(Veiculo x)
        {
           
        }

        public void _ExcluirVeiculo(Veiculo x)
        {
            _LVendas.RemoveAt(GridDados.CurrentRow.Index);
        }

        public ArrayList _ListarVeiculos()
        {
            return _LVeiculos;
        }

        public void _AdicionarCliente(Cliente x)
        {
            _LClientes.Add(x);
        }

        public void _AlterarCliente(Veiculo x)
        {

        }

        public void _ExcluirCliente()
        {
            _LClientes.RemoveAt(GridDados.CurrentRow.Index);
        }

        public ArrayList _ListarCliente()
        {
            return _LClientes;
        }

        public void _AdicionarVenda(Vendas x)
        {
            _LVendas.Add(x);
        }
        public ArrayList _RelatorioVendas()
        {
            //todas as vendas da semana.
            return _LVendas;
        }

        public void _RelatorioGeral(Veiculo x, Cliente y, Vendas z)
        {
            //veiculos comprados e vendidos, clientes novos, lucro de vendas total.
            _LGeral.Add(x);
        }
    }
}
