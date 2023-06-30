namespace SuperTrunfo
{
    public partial class Form1 : Form
    {
        private List<CartaCarro> CartasCarros, CartasJogador, CartasComputador;
        public Form1()
        {
            InitializeComponent();
            CartasCarros = new List<CartaCarro>();
            CarregarCartas();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sortear();
            foreach (var carta in CartasComputador)
            {
                lblCartasComputador.Text += carta.Nome + "\n";
            }

            foreach (var carta in CartasJogador)
            {
                lblCartasJogador.Text += carta.Nome + "\n";
            }


        }

        private void Sortear()
        {
            CartasComputador = new List<CartaCarro>();
            CartasJogador = new List<CartaCarro>();
            Random rnd = new Random();
            bool vezJogador = true;
            while (CartasCarros.Count > 0)
            {
                int posicao = rnd.Next(CartasCarros.Count);
                if (vezJogador)
                {
                    CartasJogador.Add(CartasCarros[posicao]);
                    CartasCarros.Remove(CartasCarros[posicao]);
                    vezJogador = false;
                    continue;
                }
                CartasComputador.Add(CartasCarros[posicao]);
                CartasCarros.Remove(CartasCarros[posicao]);
                vezJogador = true;
            }

        }

        private void CarregarCartas()
        {
            CartaCarro carta1 = new CartaCarro();
            carta1.Nome = "Mustang";
            carta1.VelocidadeMaxima = 250;
            carta1.Peso = 1681;
            carta1.Torque = 56.7f;
            carta1.Potencia = 483;
            CartasCarros.Add(carta1);

            CartaCarro carta2 = new CartaCarro();
            carta2.Nome = "Camaro";
            carta2.Potencia = 461;
            carta2.Torque = 62.9f;
            carta2.VelocidadeMaxima = 290;
            carta2.Peso = 1709;
            CartasCarros.Add((carta2));

            CartaCarro carta3 = new CartaCarro();
            carta3.Nome = "Lamborghini HuraCan";
            carta3.VelocidadeMaxima = 325;
            carta3.Peso = 1422;
            carta3.Torque = 61.2f;
            carta3.Potencia = 640;
            CartasCarros.Add(carta3);

            CartaCarro carta4 = new CartaCarro();
            carta4.Nome = "Ferrari 812 GTS";
            carta4.Potencia = 800;
            carta4.Torque = 73.2f;
            carta4.VelocidadeMaxima = 340;
            carta4.Peso = 1705;
            CartasCarros.Add((carta4));

            CartaCarro carta5 = new CartaCarro();
            carta5.Nome = "Fusca 1600 S";
            carta5.VelocidadeMaxima = 139;
            carta5.Peso = 800;
            carta5.Torque = 12f;
            carta5.Potencia = 65;
            CartasCarros.Add(carta5);

            CartaCarro carta6 = new CartaCarro();
            carta6.Nome = "Fiat 147 GLS 1.3";
            carta6.Potencia = 61;
            carta6.Torque = 9.9f;
            carta6.VelocidadeMaxima = 140;
            carta6.Peso = 1709;
            CartasCarros.Add((carta6));
        }
    }
}