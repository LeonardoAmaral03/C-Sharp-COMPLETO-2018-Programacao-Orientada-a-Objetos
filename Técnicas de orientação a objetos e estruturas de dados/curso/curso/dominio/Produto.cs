﻿using System;
using System.Globalization;

namespace curso.dominio {
    class Produto : IComparable {

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(int codigo, string descricao, double preco) {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public override string ToString() {
            return Codigo
                + ", "
                + Descricao
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Produto outro = (Produto)obj;
            int resultado = Descricao.CompareTo(outro.Descricao);

            if (resultado != 0) {
                return resultado;
            }
            else {
                return -Preco.CompareTo(outro.Preco);
            }
        }
    }
}
