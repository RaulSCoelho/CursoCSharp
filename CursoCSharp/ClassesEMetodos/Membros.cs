using System;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            Pessoa raul = new Pessoa();
            raul.Nome = "Raul";
            raul.Idade = 19;

            raul.ApresentarNoConsole();
            raul.Zerar();
            raul.ApresentarNoConsole();

            var abel = new Pessoa();
            abel.Nome = "Abel";
            abel.Idade = 21;

            Console.WriteLine(abel.Apresentar());
        }
    }
}
