using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesSet
    {
        public static void Executar() {
            var livro = new Produto("PS5", 5000);

            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("Tenis", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            foreach(var item in carrinho) {
                Console.WriteLine($"Item: {item.Nome} Preço: {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
