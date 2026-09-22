using System;
using System.Collections.Generic;
using System.Text;

namespace Personajes
{
    internal class Personaje
    {
        public string Nombre { get; }
        public int VidaMaxima { get; }
        public int Vida { get; private set; }
        public int AtaqueBase { get; }
        public string Arma { get; private set; }

        public Personaje(string nombre, int maxima, int ataque, string arma)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Nombre vacío.");
            if (maxima <= 0 || ataque <= 0)
                throw new ArgumentOutOfRangeException();
            Nombre = nombre.Trim();
            VidaMaxima = maxima;
            Vida = maxima;
            AtaqueBase = ataque;
            Arma = arma;
        }

        public string CuantaVida()
        {
            return $"El personaje tiene {Vida} vida.";
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }

        public string Salud()
        {
            if (Vida == VidaMaxima)
                return "está en plena forma.";
            else if (Vida > (VidaMaxima / 2))
                return "no lo lleva mal.";
            else if (Vida > 0)
                return "está jodido.";
            else
                return "está muerto.";
        }

        public void RecibirDanyo(int cantidad)
        {
            if (cantidad < 0)
                throw new ArgumentOutOfRangeException(nameof(cantidad));
            Vida -= Math.Min(cantidad, Vida);
        }

        public void Atacar(Personaje objetivo)
        {
            objetivo.RecibirDanyo(AtaqueBase);
        }

        public override string ToString()
        {
            return $"{Nombre} {Salud()} ({Vida}/{VidaMaxima}) ";
        }

    }    
}