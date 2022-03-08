using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    internal class ExemploEnum
    {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filme1 = new Filme();
            filme1.Titulo = "Avengers: Infinity War";
            filme1.GeneroDoFilme = Genero.Acao;

            Console.WriteLine($"{filme1.Titulo} é {filme1.GeneroDoFilme}");
        }
    }
}
