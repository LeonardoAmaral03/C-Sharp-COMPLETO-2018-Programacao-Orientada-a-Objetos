using System;
using System.IO;

namespace course3 {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Trabalhando com arquivos\file1.txt";

            try {
                // ao final do bloco using o recurso instanciado será fechado
                /*using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    using (StreamReader sr = new StreamReader(fs)) {
                        while (!sr.EndOfStream) {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }*/

                // instanciação do StreamReader de forma resumida
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
