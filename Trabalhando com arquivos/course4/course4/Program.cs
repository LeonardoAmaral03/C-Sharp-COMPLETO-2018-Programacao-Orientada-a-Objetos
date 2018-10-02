using System;
using System.IO;

namespace course4 {
    class Program {
        static void Main(string[] args) {

            string sourcePath = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Trabalhando com arquivos\file1.txt";
            string targetPath = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Trabalhando com arquivos\file2.txt";

            try {

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
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
