using System;
using System.Globalization;
using prop2.dominio;

namespace prop2 {
    class Tela {

        public static void MostrarMenu() {
            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");
            Console.Write("Digite uma das opções: ");
        }

        public static void ListarMarcas() {
            Console.WriteLine("LISTAGEM DE MARCAS:");
            for (int i = 0; i < Program.marcas.Count; i++) {
                Console.WriteLine(Program.marcas[i]);
            }
        }

        public static void ListarCarrosDeUmaMarca() {
            Console.Write("Digite o código da marca: ");
            int cod = int.Parse(Console.ReadLine());

            Marca marca = Program.marcas.Find(x => x.Codigo == cod);

            if (marca == null) {
                throw new ModelException("Marca com o código " + cod + " não foi encontrada!");
            }

            Console.WriteLine("Carros da marca " + marca.Nome + ":");

            for (int i = 0; i < marca.Carros.Count; i++) {
                Console.WriteLine(marca.Carros[i]);
            }
        }

        public static void CadastrarMarca() {
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("País de origem: ");
            string pais = Console.ReadLine();

            Program.marcas.Add(new Marca(codigo, nome, pais));
        }

        public static void CadastrarCarro() {
            Console.WriteLine("Digite os dados do carro:");
            Console.Write("Marca (código): ");
            int codigoMarca = int.Parse(Console.ReadLine());

            Marca marca = Program.marcas.Find(x => x.Codigo == codigoMarca);

            if (marca == null) {
                throw new ModelException("Marca com o código " + codigoMarca + " não foi encontrada!");
            }

            Console.Write("Código do carro: ");
            int codigoCarro = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Preço básico: ");
            double precoBasico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Carro carro = new Carro(codigoCarro, modelo, ano, precoBasico, marca);

            marca.Carros.Add(carro);
            marca.Carros.Sort();

            Program.carros.Add(carro);
        }

        public static void CadastrarAcessorio() {
            Console.WriteLine("Digite os dados do acessório:");
            Console.Write("Carro (código): ");
            int codigoCarro = int.Parse(Console.ReadLine());

            Carro carro = Program.carros.Find(x => x.Codigo == codigoCarro);

            if (carro == null) {
                throw new ModelException("Carro com o código " + codigoCarro + " não foi encontrado!");
            }

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            carro.Acessorios.Add(new Acessorio(descricao, preco, carro));
        }

        public static void MostrarDetalhesDeUmCarro() {
            Console.Write("Digite o código do carro: ");
            int cod = int.Parse(Console.ReadLine());

            Carro carro = Program.carros.Find(x => x.Codigo == cod);

            if (carro == null) {
                throw new ModelException("Carro com o código " + cod + " não foi encontrado!");
            }

            Console.WriteLine(carro);

            Console.WriteLine("Acessórios:");

            for (int i = 0; i < carro.Acessorios.Count; i++) {
                Console.WriteLine(carro.Acessorios[i]);
            }
        }
    }
}
