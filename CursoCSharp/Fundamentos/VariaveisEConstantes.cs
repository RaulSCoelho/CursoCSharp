using System;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia 
            double raio = 5.5;
            const double PI = 3.14;

            double area = PI * Math.Pow(raio, 2);

            Console.WriteLine(area);

        }
    }
}
