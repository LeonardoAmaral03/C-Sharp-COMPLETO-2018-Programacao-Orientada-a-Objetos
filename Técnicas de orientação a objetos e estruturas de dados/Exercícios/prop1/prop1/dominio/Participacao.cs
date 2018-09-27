using System.Globalization;

namespace prop1.dominio {
    class Participacao {

        public double Desconto { get; private set; }
        public Artista Artista { get; private set; }
        public Filme Filme { get; private set; }

        public Participacao(double desconto, Artista artista, Filme filme) {
            this.Desconto = desconto;
            this.Artista = artista;
            this.Filme = filme;
        }

        public double Custo() {
            return Artista.Cache - Desconto;
        }

        public override string ToString() {
            return Artista.Nome
                + ", Cachê: "
                + Artista.Cache.ToString("F2", CultureInfo.InvariantCulture)
                + ", Desconto: "
                + Desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + Custo().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
