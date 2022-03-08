using System;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    internal class LINQ1
    {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno(){Nome = "Raul", Idade = 19, Nota = 10.0},
                new Aluno(){Nome = "Caio", Idade = 19, Nota = 9.3},
                new Aluno(){Nome = "Andrey", Idade = 19, Nota = 8.6},
                new Aluno(){Nome = "Ana", Idade = 18, Nota = 7.5},
                new Aluno(){Nome = "Carol", Idade = 18, Nota = 6.8},
                new Aluno(){Nome = "Ana", Idade = 18, Nota = 5.8},
                new Aluno(){Nome = "Nicole", Idade = 18, Nota = 4.3},
                new Aluno(){Nome = "Evy", Idade = 18, Nota = 9.8}
            };
            Console.WriteLine("== Aprovados ================");
            var aprovados = alunos.Where(aluno => aluno.Nota >= 7).OrderBy(aluno => aluno.Nome);
            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Chamada ================");
            var chamada = alunos.OrderBy(aluno => aluno.Nome).Select(aluno => aluno.Nome);
            foreach(var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (por idade) ================");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach(var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}
