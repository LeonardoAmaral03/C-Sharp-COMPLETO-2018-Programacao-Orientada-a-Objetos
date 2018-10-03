namespace fix.Entidades {
    class Produto {

        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade) {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public double ValorTotal() {
            return Preco * Quantidade;
        }

    }
}
