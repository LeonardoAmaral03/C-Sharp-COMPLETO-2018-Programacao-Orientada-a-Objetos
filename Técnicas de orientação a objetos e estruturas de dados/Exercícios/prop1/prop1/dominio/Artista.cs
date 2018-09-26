using System;
using System.Globalization;

namespace prop1.dominio {
    class Artista : IComparable {

        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public double Cache { get; private set; }

        public Artista(int codigo, string nome, double cache) {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Cache = cache;
        }

        public override string ToString() {
            return Codigo
                + ", "
                + Nome
                + ", Cachê: "
                + Cache.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Artista outro = (Artista)obj;
            return Nome.CompareTo(outro.Nome);
        }
    }
}
