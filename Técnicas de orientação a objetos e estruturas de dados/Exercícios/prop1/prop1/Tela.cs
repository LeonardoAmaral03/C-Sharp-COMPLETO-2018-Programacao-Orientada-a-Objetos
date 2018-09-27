using System;
using System.Globalization;
using prop1.dominio;

namespace prop1 {
    class Tela {

        public static void MostrarMenu() {
            Console.WriteLine("1 – Listar artistas ordenadamente");
            Console.WriteLine("2 – Cadastrar artista");
            Console.WriteLine("3 – Cadastrar filme");
            Console.WriteLine("4 – Mostrar dados de um filme");
            Console.WriteLine("5 – Sair");
            Console.Write("Digite uma das opções: ");
        }

        public static void ListarArtistas() {
            Console.WriteLine("LISTAGEM DE ARTISTAS:");
            for (int i = 0; i < Program.artistas.Count; i++) {
                Console.WriteLine(Program.artistas[i]);
            }
        }

        public static void CadastrarArtista() {
            Console.WriteLine("Digite os dados do artista:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double valorCache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Artista artista = new Artista(codigo, nome, valorCache);
            Program.artistas.Add(artista);
            Program.artistas.Sort();
        }

        public static void CadastrarFilme() {
            Console.WriteLine("Digite os dados do filme:");
            Console.Write("Código: ");
            int codigoFilme = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Filme filme = new Filme(codigoFilme, titulo, ano);
            Console.Write("Quantas participações tem o filme? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine("Digite os dados da " + i + "ª participação:");
                Console.Write("Artista (código): ");
                int codigoArtista = int.Parse(Console.ReadLine());

                // Encontra e retorna a posição do objeto na lista (FindIndex)
                int pos = Program.artistas.FindIndex(x => x.Codigo == codigoArtista);

                if (pos == -1) {
                    throw new ModelException("Artista com o código " + codigoArtista + " não foi encontrado!");
                }

                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                filme.Participacoes.Add(new Participacao(desconto, Program.artistas[pos], filme));
            }
            Program.filmes.Add(filme);
        }

        public static void MostrarFilme() {
            Console.Write("Digite o código do filme: ");
            int codigo = int.Parse(Console.ReadLine());

            // Encontra e retorna o objeto na lista (Find)
            Filme filme = Program.filmes.Find(x => x.Codigo == codigo);

            if (filme == null) {
                throw new ModelException("Filme com o código " + codigo + " não foi encontrado!");
            }

            Console.WriteLine(filme);
        }
    }
}
