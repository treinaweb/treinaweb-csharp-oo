﻿using System;
using Personagens;

namespace _06_05_Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cavaleiro = new Cavaleiro("Aragorn", 100);
            var arqueiro = new Arqueiro("Legolas", 100);
            var mago = new Mago("Gandalf", 100, 100);

            cavaleiro.Atacar();
            cavaleiro.AtacarEspecial();
            cavaleiro.Defender();

            arqueiro.Atacar();
            arqueiro.AtacarEspecial();
            arqueiro.Defender();
            
            mago.Atacar();
            mago.AtacarEspecial();
            mago.Defender();
        }
    }
}
