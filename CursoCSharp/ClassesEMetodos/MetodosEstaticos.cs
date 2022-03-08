using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método de Classe ou Método estático
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Método de instância
        public int Somar(int a, int b) {
            return a + b;
        }
    }

    internal class MetodosEstaticos
    {
        public static void Executar() {
            Console.WriteLine($"Resultado Multiplicação: {CalculadoraEstatica.Multiplicar(2, 2)}");

            var calc = new CalculadoraEstatica();
            Console.WriteLine($"Resultado Soma: {calc.Somar(2, 2)}");
        }

    }
}
