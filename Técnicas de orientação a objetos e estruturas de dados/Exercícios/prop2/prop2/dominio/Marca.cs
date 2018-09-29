using System.Collections.Generic;
using System.Linq;

namespace prop2.dominio {
    class Marca {

        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Pais { get; private set; }
        public List<Carro> Carros { get; private set; }

        public Marca(int codigo, string nome, string pais) {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Pais = pais;
            Carros = new List<Carro>();
        }

        public override string ToString() {
            return Codigo
                + ", "
                + Nome
                + ", País: "
                + Pais
                + ", Número de carros: "
                + Carros.Count();
        }
    }
}
