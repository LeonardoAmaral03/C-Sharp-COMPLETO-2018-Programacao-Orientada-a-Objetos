using System;
using System.Collections.Generic;
using System.Globalization;

namespace prop2.dominio {
    class Carro : IComparable {

        public int Codigo { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public double PrecoBasico { get; private set; }
        public Marca Marca { get; private set; }
        public List<Acessorio> Acessorios { get; private set; }

        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca) {
            this.Codigo = codigo;
            this.Modelo = modelo;
            this.Ano = ano;
            this.PrecoBasico = precoBasico;
            this.Marca = marca;
            Acessorios = new List<Acessorio>();
        }

        public double PrecoTotal() {
            double soma = PrecoBasico;

            for (int i = 0; i < Acessorios.Count; i++) {
                soma += Acessorios[i].Preco;
            }

            return soma;
        }

        public override string ToString() {
            return Codigo
                + ", "
                + Modelo
                + ", Ano: "
                + Ano
                + ", Preço básico: "
                + PrecoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + ", Preço total: "
                + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Carro outro = (Carro)obj;

            int resultado = Modelo.CompareTo(outro.Modelo);

            if (resultado != 0) {
                return resultado;
            }
            else {
                return -PrecoTotal().CompareTo(outro.PrecoTotal());
            }
        }
    }
}
