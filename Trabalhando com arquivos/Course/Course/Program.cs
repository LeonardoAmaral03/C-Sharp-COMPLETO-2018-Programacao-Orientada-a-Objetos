using System;
using System.IO;

namespace Course {
    class Program {
        static void Main(string[] args) {

            string sourcePath = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Trabalhando com arquivos\file1.txt";
            string targetPath = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Trabalhando com arquivos\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
