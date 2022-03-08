using System;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Params
    {
        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine($"Olá, {pessoa}!");
            }
        }

        public static void Executar() {
            Recepcionar("Raul", "Abel", "Caio");
        }
    }
}
