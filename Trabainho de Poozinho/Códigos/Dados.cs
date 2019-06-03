using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabainho_de_Poozinho.Códigos
{
    class Dados : ConcessionáriaProgram

    { //arraylists para salvar os objetos
        private ArrayList _LClientes;
        private ArrayList _LVeiculos;
        private ArrayList _LVendas;
        private ArrayList _LCompras;
        private ArrayList _LGeral;

        //gerar objeto dados publico
        public Dados()
        {
            _LVeiculos = new ArrayList();
            _LClientes = new ArrayList();
            _LVendas = new ArrayList();
            _LCompras = new ArrayList();
            _LGeral = new ArrayList();
        }

        //dados veiculos
        public void _AdicionarVeiculo(Veiculo x)
        {
            //adicionar veiculo
            _LVeiculos.Add(x);
        }
        public void _ExcluirVeiculo(Veiculo x)
        {
            //excluir veiculo
            _LVeiculos.RemoveAt(GridDados.CurrentRow.Index);
        }
        public ArrayList _ListarVeiculos()
        {
            //listar todos os veiculos
            return _LVeiculos;
        }

        //dados clientes
        public void _AdicionarCliente(Cliente x)
        {
            //adcionar cliente
            _LClientes.Add(x);
        }
        public void _ExcluirCliente()
        {
            _LClientes.RemoveAt(GridDados.CurrentRow.Index);
        }
        public ArrayList _ListarCliente()
        {
            return _LClientes;
        }

        //dados vendas
        public void _AdicionarVenda(Vendas x)
        {
            _LVendas.Add(x);
        }
        public void _ExcluirVenda()
        {
            _LVendas.RemoveAt(GridDados.CurrentRow.Index);

        }
        //dados relatorio de compras dos veiculos
        public ArrayList _RelatorioCompras()
        {
            return _LCompras;
        }

        //dados relatorio de vendas dos veiculos
        public ArrayList _RelatorioVendas()//todas as vendas da semana.
        {
            return _LVendas;
        }

        //dados relatorio geral
        public ArrayList _RelatorioGeral() //gerar relatorio das compras e vendas dos veiculos
        {
            //veiculos comprados e vendidos, clientes novos, lucro de vendas total.
            return _LGeral;
        }
    }
}
