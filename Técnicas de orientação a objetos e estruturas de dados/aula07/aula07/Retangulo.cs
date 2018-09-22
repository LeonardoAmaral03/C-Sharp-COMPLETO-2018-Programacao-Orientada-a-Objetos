namespace curso {
    class Retangulo : Figura {

        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, string cor) : base(cor) {
            Largura = largura;
            Altura = altura;
        }

        public override double Area() {
            return Largura * Altura;
        }

        public override double Perimetro() {
            return 2 * (Largura + Altura);
        }
    }
}
