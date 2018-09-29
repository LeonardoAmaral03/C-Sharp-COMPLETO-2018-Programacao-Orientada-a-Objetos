using System;
using System.Collections.Generic;
using prop2.dominio;

namespace prop2 {
    class Program {

        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();

        static void Main(string[] args) {

            Marca m1 = new Marca(1001, "Volkswagen", "Alemanha");
            Marca m2 = new Marca(1002, "General Motors", "Estados Unidos");

            Carro c1 = new Carro(101, "Fusca", 1980, 5000.00, m1);
            Carro c2 = new Carro(102, "Golf", 2016, 60000.00, m1);
            Carro c3 = new Carro(103, "Fox", 2017, 30000.00, m1);
            Carro c4 = new Carro(104, "Cruze", 2016, 30000.00, m2);
            Carro c5 = new Carro(105, "Cobalt", 2015, 25000.00, m2);
            Carro c6 = new Carro(106, "Cobalt", 2017, 35000.00, m2);

            marcas.Add(m1);
            marcas.Add(m2);

            m1.Carros.Add(c1);
            m1.Carros.Add(c2);
            m1.Carros.Add(c3);
            m1.Carros.Sort();

            m2.Carros.Add(c4);
            m2.Carros.Add(c5);
            m2.Carros.Add(c6);
            m2.Carros.Sort();

            carros.Add(c1);
            carros.Add(c2);
            carros.Add(c3);
            carros.Add(c4);
            carros.Add(c5);
            carros.Add(c6);

            int opcao = 0;

            while (opcao != 7) {

                Console.Clear();
                Tela.MostrarMenu();

                try {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                }

                Console.WriteLine();

                switch (opcao) {
                    case 1:
                        Tela.ListarMarcas();
                        break;
                    case 2:
                        try {
                            Tela.ListarCarrosDeUmaMarca();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 3:
                        try {
                            Tela.CadastrarMarca();
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 4:
                        try {
                            Tela.CadastrarCarro();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 5:
                        try {
                            Tela.CadastrarAcessorio();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 6:
                        try {
                            Tela.MostrarDetalhesDeUmCarro();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Fim do programa!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
