using System;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World", "Mundo");
            Console.WriteLine(saudacao);
        }
    }
}
