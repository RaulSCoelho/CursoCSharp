using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<Tipo>
    {
        Tipo valorPrivado;
        public Tipo Coisa { get; set; }

        public Caixa(Tipo coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public Tipo metodoGenerico(Tipo valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public Tipo GetValor() {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0) {

        }
    }

    class CaixaProduto : Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto()) {

        }
    }

    internal class Genericos
    {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Método"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
