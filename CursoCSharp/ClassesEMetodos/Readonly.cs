using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetBirthDate() {
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    }

    internal class Readonly
    {
        public static void Executar() {
            var cliente1 = new Cliente("Raul Semicek Coelho", new DateTime(2002, 7, 12));

            Console.WriteLine(cliente1.Nome);
            Console.WriteLine(cliente1.GetBirthDate());
        }
    }
}
