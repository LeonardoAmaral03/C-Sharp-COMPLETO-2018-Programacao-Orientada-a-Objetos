using System;
using System.IO;
using System.Collections.Generic;

namespace course5 {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Trabalhando com arquivos\myfolder";

            try {

                // listar todas as subpastas a partir da pasta myfolder (path)
                //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                // listar todos os arquivos a partir de uma pasta
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                // criar uma nova pasta
                //Directory.CreateDirectory(path + "\\newfolder"); ou
                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
