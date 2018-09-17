using System.Globalization;

namespace curso {
    class Produto {

        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public Produto(string nome, double preco, int quantidadeEmEstoque) {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public double ValorTotalEmEstoque() {
            return preco * quantidadeEmEstoque;
        }

        public void RealizarEntrada(int quantidade) {
            quantidadeEmEstoque += quantidade;
        }

        public void RealizarSaida(int quantidade) {
            quantidadeEmEstoque -= quantidade;
        }

        // método padrão da linguagem C# para converter um objeto para string
        public override string ToString() {
            return nome
                + ", R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidadeEmEstoque
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
