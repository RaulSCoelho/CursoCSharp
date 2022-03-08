using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int num2) {
            return num + num2;
        }

        public static int Sub(this int num, int num2) {
            return num - num2;
        }
    }

    internal class MetodosDeExtensao
    {
        public static void Executar() {
            int numero = 5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Sub(3));
            
            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Sub(3));
        }
    }
}
