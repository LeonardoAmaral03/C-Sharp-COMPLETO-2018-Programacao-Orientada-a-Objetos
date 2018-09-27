using System.Collections.Generic;
using System.Globalization;

namespace prop1.dominio {
    class Filme {

        public int Codigo { get; private set; }
        public string Titulo { get; private set; }
        public int Ano { get; private set; }
        public List<Participacao> Participacoes { get; private set; }

        public Filme(int codigo, string titulo, int ano) {
            this.Codigo = codigo;
            this.Titulo = titulo;
            this.Ano = ano;
            Participacoes = new List<Participacao>();
        }

        public double CustoTotal() {
            double soma = 0.0;
            for (int i = 0; i < Participacoes.Count; i++) {
                soma += Participacoes[i].Custo();
            }
            return soma;
        }

        public override string ToString() {
            string texto;
            texto = "Filme: "
                + Codigo
                + ", Título: "
                + Titulo
                + ", Ano: "
                + Ano + "\n"
                + "Participações:\n";

            for (int i = 0; i < Participacoes.Count; i++) {
                texto += Participacoes[i] + "\n";
            }

            texto += "Custo total do filme: " + CustoTotal().ToString("F2", CultureInfo.InvariantCulture);
            return texto;
        }

    }
}
