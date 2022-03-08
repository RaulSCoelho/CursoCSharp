using System;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public double Dividir(double a, double b) {
            return a / b;
        }

    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a) {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    internal class MetodosComRetorno
    {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();

            Console.WriteLine(calculadoraComum.Somar(5, 5));
            Console.WriteLine(calculadoraComum.Subtrair(5, 5));
            Console.WriteLine(calculadoraComum.Multiplicar(5, 5));
            Console.WriteLine(calculadoraComum.Dividir(5, 5));

            Console.WriteLine();

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
            int resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
