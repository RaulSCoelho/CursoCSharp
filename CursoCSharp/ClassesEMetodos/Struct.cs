using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }

    internal class Struct
    {
        public static void Executar() {
            Coordenada inicial;
            inicial.X = 2;
            inicial.Y = 2;

            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine($"X = {inicial.X}");
            Console.WriteLine($"Y = {inicial.Y}");

            var final = new Coordenada(9, 1);
            final.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine($"X = {final.X}");
            Console.WriteLine($"Y = {final.Y}");
        }
    }
}
