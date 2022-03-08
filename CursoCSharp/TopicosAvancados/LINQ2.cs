using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
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

            var raul = alunos.Single(aluno => aluno.Nome.Equals("Raul"));
            Console.WriteLine($"{raul.Nome}: {raul.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno não encontrado!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var siclano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Siclano"));
            if (siclano == null) {
                Console.WriteLine("Aluno não encontrado!");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somaNota = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somaNota);

            var mediaNota = alunos.Where(aluno => aluno.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNota);
        }
    }
}
