namespace curso {
    class Retangulo {

        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura) {
            Largura = largura;
            Altura = altura;
        }

        public double Area() {
            return Largura * Altura;
        }

    }
}
