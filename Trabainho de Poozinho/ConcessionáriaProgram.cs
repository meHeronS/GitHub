using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabainho_de_Poozinho
{
    public partial class ConcessionáriaProgram : Form
    {
        private Códigos.Operacoes MinhasOP;
        public ConcessionáriaProgram()
        {
            InitializeComponent();            
        }
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == true && MinhasOP.ADVenda == false)
            {
                GridDados.DataSource = null;
                MinhasOP.InserirVeiculo();
            }
            if (MinhasOP.ADCliente == true && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == false)
            {
                GridDados.DataSource = null;
                MinhasOP.InserirCliente();
            }
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == true)
            {
                GridDados.DataSource = null;
                MinhasOP.Vender();
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == true && MinhasOP.ADVenda == false)
            {
                MinhasOP.PesquisarVeiculo();
            }
            if (MinhasOP.ADCliente == true && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == false)
            {
                MinhasOP.PesquisarCliente();
            }
        }
        private void GridDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == true && MinhasOP.ADVenda == false)
            {
                MinhasOP.InserirVeiculoCell();
            }
            if (MinhasOP.ADCliente == true && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == false)
            {
                MinhasOP.InserirClienteCell();
            }
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == true)
            {
                MinhasOP.VenderCell();
            }
        }
        private void BtnVeículos_Click(object sender, EventArgs e)//botao de controle de veiculos
        {
            //ao clicar no botao limpa grid ativa o botao bool e ativa a possibiliadade de adicionar e remover e etc das objetos
            GridDados.DataSource = null; //Limpar dados do grid
            MinhasOP.ADVeiculo = true;
            MinhasOP.ADCliente = false;
            MinhasOP.ADVenda = false;
            MinhasOP.GridVeiculos();
        }
        private void BtnCliente_Click(object sender, EventArgs e) //botao de controle de clientes
        {
            GridDados.DataSource = null;
            MinhasOP.ADVeiculo = false;
            MinhasOP.ADCliente = true;
            MinhasOP.ADVenda = false;
            MinhasOP.GridCliente();
        }
        private void BtnVenda_Click(object sender, EventArgs e) //botao de fazer vendas
        {
            GridDados.DataSource = null;
            MinhasOP.ADCliente = false;
            MinhasOP.ADVeiculo = false;
            MinhasOP.ADVenda = true;
        }
        private void BtnRelCompra_Click(object sender, EventArgs e)//botao de relatorio de compra de veiculos
        {
            GridDados.DataSource = null;
        }   

        private void BtnRelVenda_Click(object sender, EventArgs e)//botao de relatorio de vendas
        {
            GridDados.DataSource = null;
            MinhasOP.RelatorioVendas();
        }

        private void BtnRelGeral_Click(object sender, EventArgs e)//botao de relatorio de todas as vendas e compras de veiculos e lucro final
        {

            GridDados.DataSource = null;
        }

        private void ConcessionáriaProgram_Load(object sender, EventArgs e) // o q o programa inicia mostrando
        {
            MinhasOP = new Códigos.Operacoes();
        }        
    }
}
