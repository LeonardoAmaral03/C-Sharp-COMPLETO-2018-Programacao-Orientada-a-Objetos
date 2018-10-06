using System;
using System.Collections.Generic;
using System.IO;
using course4.Entities;

namespace course4 {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Interfaces\in.txt";

            try {
                using(StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
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
