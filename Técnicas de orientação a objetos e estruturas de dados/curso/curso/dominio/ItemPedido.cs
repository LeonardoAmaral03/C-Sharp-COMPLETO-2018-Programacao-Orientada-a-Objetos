using System.Globalization;

namespace curso.dominio {
    class ItemPedido {

        public int Quantidade { get; set; }
        public double PorcentagemDesconto { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }

        public ItemPedido(int quantidade, double porcentagemDesconto, Pedido pedido, Produto produto) {
            this.Quantidade = quantidade;
            this.PorcentagemDesconto = porcentagemDesconto;
            this.Pedido = pedido;
            this.Produto = produto;
        }

        public double SubTotal() {
            double desconto = Produto.Preco * PorcentagemDesconto / 100.00;
            return (Produto.Preco - desconto) * Quantidade;
        }

        public override string ToString() {
            return Produto.Descricao
                + ", Preço: "
                + Produto.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Qte: "
                + Quantidade
                + ", Desconto: "
                + PorcentagemDesconto.ToString("F1", CultureInfo.InvariantCulture)
                + "%, Subtotal: "
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
