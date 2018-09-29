using System.Globalization;

namespace prop2.dominio {
    class Acessorio {

        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public Carro Carro { get; private set; }

        public Acessorio(string nome, double preco, Carro carro) {
            this.Nome = nome;
            this.Preco = preco;
            this.Carro = carro;
        }

        public override string ToString() {
            return Nome
                + ", Preço: "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
