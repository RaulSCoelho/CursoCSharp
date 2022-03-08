using System;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;

        public static void Executar() {
            // Acessar variável 'a' dentro do método Executar
            var desafio = new DesafioAtributo();

            Console.WriteLine(desafio.a);
        }
    }
}
