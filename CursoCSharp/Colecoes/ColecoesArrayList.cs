﻿using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList
    {
        public static void Executar() {
            var arrayList = new ArrayList {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14);

            foreach(var item in arrayList) {
                Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}
