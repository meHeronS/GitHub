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
        //inicialização do programa
        private void ConcessionáriaProgram_Load(object sender, EventArgs e) //tudo que inicia quando o programa é aberto
        {
            MinhasOP = new Códigos.Operacoes();
        }

        //Ações do Grid
        private void GridDados_CellEndEdit(object sender, DataGridViewCellEventArgs e) //para edita na celula que é gerada
        {
            //as possibilidades feitas nos botoes ao serem clicados
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
        } //edição na celula?

        //botoes de ações
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == true && MinhasOP.ADVenda == false) // para adicionar veiculo
            {
                GridDados.DataSource = null;
                MinhasOP.InserirVeiculo();
            }
            if (MinhasOP.ADCliente == true && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == false) //para adicionar veiculo
            {
                GridDados.DataSource = null;
                MinhasOP.InserirCliente();
            }
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == true) //para adicionar venda
            {
                GridDados.DataSource = null;
                MinhasOP.Vender();
            }
        }//botao para adicionar objeto
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == true && MinhasOP.ADVenda == false)
            {
                GridDados.DataSource = null;
                MinhasOP.ExcluirVeiculo();
            }
            if (MinhasOP.ADCliente == true && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == false)
            {
                GridDados.DataSource = null;
                MinhasOP.ExcluirCliente();
            }
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == true)
            {
                GridDados.DataSource = null;
                MinhasOP.ExcluirVenda();
            }
        }//botao para exclusao do que esta selecionado
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == true && MinhasOP.ADVenda == false)
            {
                GridDados.DataSource = null;
                MinhasOP.AlterarVeiculo();
            }
            if (MinhasOP.ADCliente == true && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == false)
            {
                GridDados.DataSource = null;
                MinhasOP.AlterarCliente();
            }
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == true)
            {
                GridDados.DataSource = null;
                MinhasOP.AlterarVenda();
            }
        }//botao para alteração dos dados
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
            if (MinhasOP.ADCliente == false && MinhasOP.ADVeiculo == false && MinhasOP.ADVenda == true)
            {
                MinhasOP.PesquisarVenda();
            }
        }//botao de pesquisa

        //botoes de objetos
        private void BtnVeículos_Click(object sender, EventArgs e)//botao de controle de veiculos
        {
            //ao clicar no botao limpa grid ativa o botao bool e ativa a possibiliadade de adicionar e remover e etc das objetos
            GridDados.DataSource = null; //Limpar dados do grid
            //define os booleanos 
            MinhasOP.ADVeiculo = true;
            MinhasOP.ADCliente = false;
            MinhasOP.ADVenda = false;
            //carrega o grid dos veículos
            MinhasOP.GridVeiculos();
        }
        private void BtnCliente_Click(object sender, EventArgs e) //botao de controle de clientes
        {
            //ao clicar no botao limpa grid ativa o botao bool e ativa a possibiliadade de adicionar e remover e etc das objetos
            GridDados.DataSource = null; //limpa o grid
            //define os booleanos
            MinhasOP.ADVeiculo = false;
            MinhasOP.ADCliente = true;
            MinhasOP.ADVenda = false;
            //carrega o grid dos clientes
            MinhasOP.GridCliente();
        }
        private void BtnVenda_Click(object sender, EventArgs e) //botao de fazer vendas
        {
            //ao clicar no botao limpa grid ativa o botao bool e ativa a possibiliadade de adicionar e remover e etc das objetos
            GridDados.DataSource = null;//limpa os dados do grid
            //define os booleanos das vendas
            MinhasOP.ADCliente = false;
            MinhasOP.ADVeiculo = false;
            MinhasOP.ADVenda = true;
            //carrega o grid de executar a venda
            MinhasOP.Vender();
        }
        private void BtnRelCompra_Click(object sender, EventArgs e)//botao de relatorio de compra de veiculos
        {
            //limpa o grid
            GridDados.DataSource = null;
            //lista todos os veiculos comprados
            MinhasOP.RelatorioCompras();
        }   
        private void BtnRelVenda_Click(object sender, EventArgs e)//botao de relatorio de vendas
        {
            //limpa o grid
            GridDados.DataSource = null;
            //carrega todas as vendas feitas
            MinhasOP.RelatorioVendas();
        }
        private void BtnRelGeral_Click(object sender, EventArgs e)//botao de relatorio de todas as vendas e compras de veiculos e lucro final
        {
            //limpa todo o grid
            GridDados.DataSource = null;
            //carrega tudo que ja foi feito
            MinhasOP.RelatorioGeral();
        }
    }
}
