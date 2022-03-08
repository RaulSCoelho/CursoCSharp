using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2008, "Homem de Ferro");
            filmes.Add(20012, "Os Vingadores");

            if (filmes.ContainsKey(2008)) {
                Console.WriteLine($"2008: {filmes[2008]}");
                Console.WriteLine($"2008: {filmes.GetValueOrDefault(2008)}");// Nao gera erro se nao existir a Key
            }

            Console.WriteLine(filmes.ContainsValue("Homem de Ferro"));

            Console.WriteLine($"Removeu? {filmes.Remove(2008)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme 2006: {filme2006}");

            foreach (var key in filmes.Keys) {
                Console.WriteLine(key);
            }

            foreach (var value in filmes.Values) {
                Console.WriteLine(value);
            }

            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Key}: {filme.Value}");
            }

            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Key}: {filme.Value}");
            }
        }
    }
}
