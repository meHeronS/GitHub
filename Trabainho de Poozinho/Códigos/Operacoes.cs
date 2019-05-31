﻿using System;

namespace Trabainho_de_Poozinho.Códigos
{
    class Operacoes : ConcessionáriaProgram
    {
        private Dados MeusDados;
        public bool ADCliente, ADVeiculo, ADVenda; //teste execução de açoes

        public Operacoes()
        {
            MeusDados = new Dados();
        }
        public void GridVeiculos()
        {
            GridDados.DataSource = null;
            GridDados.DataSource = MeusDados._ListarVeiculos();
            GridDados.ClearSelection();
            GridDados.Columns[0].Width = 150; //Modelo
            GridDados.Columns[1].Width = 80;  //Ano
            GridDados.Columns[4].Width = 100; //Cor
            GridDados.Columns[2].Width = 100; //Placa
            GridDados.Columns[3].Width = 150; //Chassi
            GridDados.Columns[5].Width = 100; //Valor de Compra
            GridDados.Columns[6].Width = 100; //Valor de Venda
        }
        public void InserirVeiculo()
        {
            Veiculo NVeiculo = new Veiculo();

            NVeiculo.Modelo = "Modelo do veículo";
            NVeiculo.Ano = "Ano";
            NVeiculo.Cor = "Cor";
            NVeiculo.Placa = "Placa";
            NVeiculo.Chassi = "Chassi";
            NVeiculo.ValorCompra = 0;
            NVeiculo.ValorVenda = 0;
            NVeiculo.Disponibilidade = true;

            MeusDados._AdicionarVeiculo(NVeiculo);
            GridVeiculos();
            
            GridDados.CurrentCell = GridDados.Rows[GridDados.RowCount - 1].Cells[0];
        }
        public void InserirVeiculoCell()
        {
            Veiculo x = new Veiculo();
            string status, VCompra, VVenda; 
            status = "Disponível";
            x.Modelo = GridDados.CurrentRow.Cells[0].Value.ToString();
            x.Ano = GridDados.CurrentRow.Cells[1].Value.ToString();
            x.Cor = GridDados.CurrentRow.Cells[2].Value.ToString();
            x.Placa = GridDados.CurrentRow.Cells[3].Value.ToString();
            x.Chassi = GridDados.CurrentRow.Cells[4].Value.ToString();
            VCompra = GridDados.CurrentRow.Cells[5].Value.ToString();
            x.ValorCompra = Convert.ToDouble(VCompra);
            VVenda = GridDados.CurrentRow.Cells[6].Value.ToString();
            x.ValorVenda = Convert.ToDouble(VVenda);
            x.Disponibilidade = true;
            status = GridDados.CurrentRow.Cells[7].Value.ToString();
            MeusDados._ListarVeiculos()[GridDados.CurrentRow.Index] = x;            
        }

        public void ExcluirVeiculo()
        {
            MeusDados._ExcluirCliente();
        }
        public void AlterarVeiculo()
        {

        }
        public void PesquisarVeiculo()
        {
            string Busca = BtnPesquisa.Text;
           
            BtnPesquisa.Text = "";

            GridDados.ClearSelection();

            for (int i = 0; i < GridDados.RowCount; i++)
            {
                if (GridDados.Rows[i].Cells[0].Value.ToString() == Busca)
                {
                    GridDados.CurrentCell = GridDados.Rows[i].Cells[0];
                }
            }
        }
        public void GridCliente()
        {
            GridDados.DataSource = null;
            GridDados.DataSource = MeusDados._ListarVeiculos();
            GridDados.ClearSelection();
            GridDados.Columns[0].Width = 150; //Modelo
            GridDados.Columns[1].Width = 80;  //Ano
            GridDados.Columns[4].Width = 100; //Cor
            GridDados.Columns[2].Width = 100; //Placa
            GridDados.Columns[3].Width = 150; //Chassi
            GridDados.Columns[5].Width = 100; //Valor de Compra
            GridDados.Columns[6].Width = 100; //Valor de Venda
        }
        public void InserirCliente()
        {
            Cliente NCliente = new Cliente();

            NCliente.Nome = "Nome";
            NCliente.Rg = "RG";
            NCliente.Cpf = "CPF";
            NCliente.EndereçoRua = "Rua";
            NCliente.EndereçoNum = "Número";
            NCliente.EndereçoBairro = "Bairro";
            NCliente.EndereçoCidade = "Cidade";
            NCliente.EndereçoEstado = "Estado";

            MeusDados._AdicionarCliente(NCliente);
            GridCliente();

            GridDados.CurrentCell = GridDados.Rows[GridDados.RowCount - 1].Cells[0];
        }
        public void InserirClienteCell()
        {
            Cliente x = new Cliente();

            x.Nome = GridDados.CurrentRow.Cells[0].Value.ToString();
            x.Rg = GridDados.CurrentRow.Cells[1].Value.ToString();
            x.Cpf = GridDados.CurrentRow.Cells[2].Value.ToString();
            x.Telefone = GridDados.CurrentRow.Cells[3].Value.ToString();

            MeusDados._ListarCliente()[GridDados.CurrentRow.Index] = x;

            //GridDados.CurrentCell = GridDados.Rows[GridDados.RowCount - 1].Cells[0];

        }
        public void ExcluirCliente()
        {

        }
        public void AlterarCliente()
        {

        }
        public void PesquisarCliente()
        {
            string Busca = BtnPesquisa.Text;

            BtnPesquisa.Text = "";

            GridDados.ClearSelection();

            for (int i = 0; i < GridDados.RowCount; i++)
            {
                if (GridDados.Rows[i].Cells[0].Value.ToString() == Busca)
                {
                    GridDados.CurrentCell = GridDados.Rows[i].Cells[0];
                }
            }
        }
        public void GridVendas()
        {
            GridDados.DataSource = null;
            GridDados.DataSource = MeusDados._ListarVeiculos();
            GridDados.ClearSelection();
            GridDados.Columns[0].Width = 150; //Modelo
            GridDados.Columns[1].Width = 80;  //Ano
            GridDados.Columns[4].Width = 100; //Cor
            GridDados.Columns[2].Width = 100; //Placa
            GridDados.Columns[3].Width = 150; //Chassi
            GridDados.Columns[5].Width = 100; //Valor de Compra
            GridDados.Columns[6].Width = 100; //Valor de Venda
        }
        public void Vender()//Veiculo x, Cliente y
        {
            Vendas NVenda = new Vendas();

            NVenda.ValorVenda = double.Parse(Console.ReadLine());
           // NVenda.Lucro = x.ValorVenda - NVenda.ValorVenda;
           // NVenda.Modelo = x.Modelo;
           // NVenda.Placa = x.Placa;
           // NVenda.NCliente = y.Nome;
           // NVenda.FormaPag = Console.ReadLine();

            // x.Disponibilidade = false;

            MeusDados._AdicionarVenda(NVenda);
        }

        public void RelatorioCompras()
        {
            GridDados.DataSource = null;
            GridDados.DataSource = MeusDados._ListarVeiculos();
            GridDados.ClearSelection();
            GridDados.Columns[0].Width = 200; //Modelo
            GridDados.Columns[1].Width = 80;  //Ano
            GridDados.Columns[4].Width = 100; //Cor
            GridDados.Columns[2].Width = 100; //Placa
            GridDados.Columns[3].Width = 200; //Chassi
            GridDados.Columns[5].Width = 100; //Valor de Compra
            GridDados.Columns[6].Width = 100; //Valor de Venda
        }

        public void RelatorioVendas()
        {
            GridDados.DataSource = null;
            GridDados.DataSource = MeusDados._RelatorioVendas();
            GridDados.ClearSelection();
            GridDados.Columns[0].Width = 200; //Modelo
            GridDados.Columns[1].Width = 80; //Ano
            GridDados.Columns[2].Width = 100; //Placa
            GridDados.Columns[3].Width = 200; //Cliente
            GridDados.Columns[4].Width = 100; //Valor
            GridDados.Columns[5].Width = 100; //Forma de Pagamento
        }
        public void VenderCell()
        {
            Veiculo x = new Veiculo();

            x.Modelo = GridDados.CurrentRow.Cells[0].Value.ToString();
            x.Ano = GridDados.CurrentRow.Cells[1].Value.ToString();
            x.Cor = GridDados.CurrentRow.Cells[2].Value.ToString();
            x.Placa = GridDados.CurrentRow.Cells[3].Value.ToString();

            MeusDados._ListarVeiculos()[GridDados.CurrentRow.Index] = x;

        }

        public void RelatorioGeral() //imprime todas as compras e vendas e mostra o lucro final
        {
            GridDados.DataSource = null;
            GridDados.DataSource = MeusDados._RelatorioVendas(); //receber veiculos e clientes
            GridDados.ClearSelection();
            GridDados.Columns[0].Width = 200; //Modelo
            GridDados.Columns[1].Width = 80; //Ano
            GridDados.Columns[2].Width = 100; //Placa
            GridDados.Columns[3].Width = 200; //Cliente
            GridDados.Columns[4].Width = 100; //Valor
            GridDados.Columns[5].Width = 100; //Forma de Pagamento

        }
        
    }
}
