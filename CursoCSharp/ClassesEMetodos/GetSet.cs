﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //if (cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {

        }

        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            // 1 Opção
            //if (cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}

            // 2 Opção
            //Cilindrada = Math.Abs(cilindrada);

            // 3 Opção
            Cilindrada = cilindrada;
        }
    }

    internal class GetSet
    {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine($"Moto 1: {moto1.GetMarca()} {moto1.GetModelo()} {moto1.GetCilindrada()}");

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);

            Console.WriteLine($"Moto 2: {moto2.GetMarca()} {moto2.GetModelo()} {moto2.GetCilindrada()}");
        }
    }
}
