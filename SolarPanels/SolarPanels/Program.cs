using System;
using System.Collections.Generic;

namespace SolarPanels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un area");
            double area = double.Parse(Console.ReadLine());

            foreach (int element in SolarPanels(area))
            {
                Console.WriteLine("Area del Cuadrante: " + element);
            }

            static List<int> SolarPanels(double area)
            {
                List<int> cuadrantes = new List<int>();

                while (area >= 1)
                {
                    double raiz = Math.Floor(Math.Sqrt(area));
                    double areaCuadrante = raiz * raiz;
                    area -= areaCuadrante;
                    cuadrantes.Add(Convert.ToInt32(areaCuadrante));

                }

                return cuadrantes;
            }

        }
    }
}
