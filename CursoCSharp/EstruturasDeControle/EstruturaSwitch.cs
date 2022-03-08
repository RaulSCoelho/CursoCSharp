using System;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            char continuar;

            do {
                Console.Write("Escreva um numero: ");
                int.TryParse(Console.ReadLine(), out int numero);

                switch (numero) {
                    case 0:
                        Console.WriteLine("Péssimo");
                        break;
                    case 1:
                    case 2:
                        Console.WriteLine("Ruim");
                        break;
                    case 3:
                        Console.WriteLine("Bom");
                        break;
                    case > 3:
                        Console.WriteLine("Muito Bom!");
                        break;
                }

                Console.Write("Você quer continuar? (s/n) ");
                char.TryParse(Console.ReadLine().ToLower(), out continuar);
                Console.WriteLine();
            } while (continuar == 's');
        }
    }
}
