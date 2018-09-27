﻿using System;
using System.Collections.Generic;
using prop1.dominio;

namespace prop1 {
    class Program {

        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();

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
                    opcao = 0;
                }

                Console.WriteLine();

                switch (opcao) {
                    case 1:
                            Tela.ListarArtistas();
                        break;
                    case 2:
                        try {
                            Tela.CadastrarArtista();
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 3:
                        try {
                            Tela.CadastrarFilme();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 4:
                        try {
                            Tela.MostrarFilme();
                        }
                        catch (ModelException e) {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
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
