using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Raul";
            alunos[1] = "Nicole";
            alunos[2] = "Evy";
            alunos[3] = "Carol";
            alunos[4] = "Ana";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            //for(int i = 0; i < notas.Length; i++) {
            //    somatorio+= notas[i];
            //}
            foreach (var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'a', 'b', 'c' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
