﻿using System;
using System.Net.WebSockets;

namespace Batalla_naval_Julian_Monroy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var yfilas = 10;
            var xcolumnas = 10;

            Console.WriteLine("el barco va a estar horizontal o vertical? (horizontal 0 - Vertical 1)");
            int horizontal = 0, vertical = 1;
            int posicionhv = Convert.ToInt32(Console.ReadLine());
            

            while (posicionhv > 1)
            {
                Console.WriteLine("Solo se acepta 0 o 1");
                posicionhv = Convert.ToInt32(Console.ReadLine());
            } 

            Console.WriteLine("que longitud va a tener el barco? (No debe ser mayor a 4)");
            int longitud = Convert.ToInt32(Console.ReadLine());

            while (longitud > 4)
            {
                Console.WriteLine("ingrese un valor que no sea mayor a 4");
                longitud = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("donde empezara el barco? ingrese la coordenada de la siguiente forma --> x,y:");
            string posicionbarco = Console.ReadLine(); 
            string[] coordenadas = posicionbarco.Split(',');


            for (int i = 0; i < yfilas; i++)
            {
                for (int j = 0; j < xcolumnas; j++)
                {
                    Console.Write(" ~");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese las coordenadas del barco ");
            string ataquebarco = (Console.ReadLine());

            if (ataquebarco == posicionbarco);

            {
                for (int i = 0; i < yfilas; i++)
                {
                    for (int j = 0; j < xcolumnas; j++)
                    { 
                       Console.Write(" ~");
                    }
                    Console.WriteLine();
                    if (i == 0)
                    {
                        Console.Write("0"); ;
                    }
                }
                Console.WriteLine();
                
            }
            

            
        }
    }
}


