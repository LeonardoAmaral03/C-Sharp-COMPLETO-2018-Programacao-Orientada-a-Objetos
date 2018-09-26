using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prop1.dominio;

namespace prop1 {
    class Program {

        public static List<Artista> artistas = new List<Artista>();

        static void Main(string[] args) {

            int opcao = 0;

            artistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            artistas.Sort();

            while (opcao != 5) {

                Console.Clear();
                Tela.MostrarMenu();

                try {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                }

                switch (opcao) {
                    case 1:
                        try {
                            Tela.ListarArtistas();
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
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
