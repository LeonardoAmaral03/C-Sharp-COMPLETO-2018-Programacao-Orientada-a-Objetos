using System;
using System.Collections.Generic;
using System.Globalization;

namespace curso.dominio {
    class Pedido {

        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public List<ItemPedido> Itens { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano) {
            this.Codigo = codigo;
            Data = new DateTime(ano, mes, dia);
            Itens = new List<ItemPedido>();
        }

        public double ValorTotal() {
            double soma = 0.0;

            for (int i = 0; i < Itens.Count; i++) {
                soma += Itens[i].SubTotal();
            }

            return soma;
        }

        public override string ToString() {
            string s = "Pedido: " + Codigo
                + ", data: " + Data.Day + "/" + Data.Month + "/" + Data.Year + "\n"
                + "Itens:\n";

            for (int i = 0; i < Itens.Count; i++) {
                s += Itens[i] + "\n";
            }

            s += "Total do pedido: " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);

            return s;
        }

    }
}
