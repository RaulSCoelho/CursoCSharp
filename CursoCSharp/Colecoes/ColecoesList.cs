using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }

    internal class ColecoesList
    {
        public static void Executar() {
            var livro = new Produto("PS5", 5000);

            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("Tenis", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach(var item in carrinho) {
                Console.Write($"{carrinho.IndexOf(item)} ");
                Console.WriteLine($"Item: {item.Nome} Preço: {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
