using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
