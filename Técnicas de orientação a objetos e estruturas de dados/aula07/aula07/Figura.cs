namespace curso {
    // Classe abstrata e Interfaces não podem ser instanciadas

    // Classe abstrata - é uma classe que possui pelo menos um método abstrato (sem implementação)
    abstract class Figura {

        public string Cor { get; set; }

        public Figura(string cor) {
            Cor = cor;
        }

        public abstract double Area();
        public abstract double Perimetro();
    }

    //  Interface - é um tipo que possui apenas métodos abstratos
    /*
    interface Figura {

        double Area();
        double Perimetro();

        // no caso da interface não precisa de override na assinatura dos métodos das subclasses
    }
    */
}
