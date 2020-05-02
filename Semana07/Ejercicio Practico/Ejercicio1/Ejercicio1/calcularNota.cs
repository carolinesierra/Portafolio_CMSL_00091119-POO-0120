using System;
using System.Collections.Generic;


namespace Ejercicio1
{
    public static class calcularNota
    {
        public static double Calcular(List<Evaluacion> ev)
        {
            double sumas = 0, nota = 0;
            foreach (var p in ev)
            {
                Console.WriteLine("Digite la nota " + p.Nombre + ": ");
                nota = Convert.ToDouble(Console.ReadLine());
                sumas += nota * (p.Porcentaje / 100.0);
            }
            return sumas; 
        }
    }
}