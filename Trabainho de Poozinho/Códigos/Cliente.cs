using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabainho_de_Poozinho
{
    public class Cliente
    {
        private string nome;
        private string rg;
        private string cpf;
        private string telefone;
        private string endereçoRua;
        private string endereçoNum;
        private string endereçoBairro;
        private string endereçoCep;
        private string endereçoCidade;
        private string endereçoEstado;

        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string EndereçoRua { get => endereçoRua; set => endereçoRua = value; }
        public string EndereçoNum { get => endereçoNum; set => endereçoNum = value; }
        public string EndereçoBairro { get => endereçoBairro; set => endereçoBairro = value; }
        public string EndereçoCep { get => endereçoCep; set => endereçoCep = value; }
        public string EndereçoCidade { get => endereçoCidade; set => endereçoCidade = value; }
        public string EndereçoEstado { get => endereçoEstado; set => endereçoEstado = value; }

        public void XML()
        {
           
        }
        

    }
}
