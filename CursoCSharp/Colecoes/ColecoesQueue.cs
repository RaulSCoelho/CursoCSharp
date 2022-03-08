using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar() {
            var fila = new Queue<string>();

            fila.Enqueue("Raul");
            fila.Enqueue("Helo");
            fila.Enqueue("Caio");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count());

            Console.WriteLine();

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count());

            Console.WriteLine();

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
