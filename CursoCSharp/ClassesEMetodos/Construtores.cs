using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Fabricante;
        public string Modelo;
        public int Ano;

        public Carro(string fabricante, string modelo, int ano) {
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
        }

        public Carro() {

        }
    }

    class Construtores
    {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "Tesla";
            carro1.Modelo = "Model X";
            carro1.Ano = 2022;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Tesla", "Roadster", 2022);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro() {
                Fabricante = "Audi",
                Modelo = "RS e-tron GT",
                Ano = 2022,
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
