namespace Trabainho_de_Poozinho
{
    public class Veiculo
    {

        private string modelo;
        private string chassi;
        private string placa;
        private string cor;
        private string ano;
        private double valorCompra;
        private double valorVenda;
        public bool Disponibilidade = true;
        public string Modelo { get => modelo; set => modelo = value; }
        public string Chassi { get => chassi; set => chassi = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Ano { get => ano; set => ano = value; }
        public double ValorCompra { get => valorCompra; set => valorCompra = value; }
        public double ValorVenda { get => valorVenda; set => valorVenda = value; }
    }
}
