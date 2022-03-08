using System;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            if (Nome != "" && Idade >= 0) {
                return string.Format($"Olá, me chamo {Nome} e tenho {Idade} anos.");
            } else {
                return string.Empty;
            }
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
