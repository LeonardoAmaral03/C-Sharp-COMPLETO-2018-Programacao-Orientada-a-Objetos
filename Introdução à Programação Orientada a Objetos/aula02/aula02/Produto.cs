using System.Globalization;

namespace curso {
    class Produto {

        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }

        //Construtor
        public Produto(string nome, double preco, int quantidadeEmEstoque) {
            this.Nome = nome;
            this.Preco = preco;
            this.QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        //Sobrecarga - permite definir mais de uma versão da mesma operação, diferencinado-as pela lista de parâmetros
        public Produto(string nome, double preco) {
            this.Nome = nome;
            this.Preco = preco;
            this.QuantidadeEmEstoque = 0;
        }

        public double ValorTotalEmEstoque() {
            return Preco * QuantidadeEmEstoque;
        }

        public void RealizarEntrada(int quantidade) {
            QuantidadeEmEstoque += quantidade;
        }

        public void RealizarSaida(int quantidade) {
            QuantidadeEmEstoque -= quantidade;
        }

        // método padrão da linguagem C# para converter um objeto para string
        public override string ToString() {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + QuantidadeEmEstoque
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
