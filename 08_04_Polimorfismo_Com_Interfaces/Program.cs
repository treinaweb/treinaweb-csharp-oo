﻿using System;
using System.Collections.Generic;
using Itens;

namespace _08_04_Polimorfismo_Com_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var espada = new Espada("Excalibur", 10, 10, 100);
            var pocao = new Pocao("Poção de Vida", 20, 20, 50);
            var joia = new Joia("Diamante", 30, 30, 100);

            var itens = new List<Item>();
            itens.Add(espada);
            itens.Add(pocao);
            itens.Add(joia);

            foreach(var item in itens)
            {
                if(item is IColecionavel)
                {
                    (item as IColecionavel).Colecionar();
                }

                if(item is IConsumivel)
                {
                    (item as IConsumivel).Consumir();
                }

                if(item is Espada)
                {
                    Console.WriteLine((item as Espada).Dano);
                }
            }
        }
    }
}
