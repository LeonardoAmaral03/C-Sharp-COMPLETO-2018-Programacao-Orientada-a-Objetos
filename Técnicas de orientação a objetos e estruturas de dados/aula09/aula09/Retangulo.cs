namespace aula09 {
    class Retangulo {

        public Cor Cor { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor) {
            Largura = largura;
            Altura = altura;
            Cor = cor;
        }

        public double Area() {
            return Largura * Altura;
        }

    }
}
