using System;
using System.IO;

namespace course2 {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Trabalhando com arquivos\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);

                sr = File.OpenText(path); // O OpenText(path) implicitamente instancia o FileStream e instancia o StreamReader em cima dele

                while (!sr.EndOfStream) { // enquanto não chegar no final da stream
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }

        }
    }
}
