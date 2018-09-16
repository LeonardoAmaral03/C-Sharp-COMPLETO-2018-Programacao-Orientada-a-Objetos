using System.Globalization;

namespace curso {
    class Produto {

        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        // método padrão da linguagem C# para converter um objeto para string
        public override string ToString() {
            return nome
                + ", "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidadeEmEstoque;
        }

    }
}
