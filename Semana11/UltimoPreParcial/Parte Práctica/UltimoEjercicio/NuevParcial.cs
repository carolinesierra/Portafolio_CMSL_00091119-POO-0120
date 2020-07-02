using System;
using System.Collections.Generic;

namespace UltimoEjercicio
{
    public  class NuevParcial : IEvaluation
    {
        public void evaluaciones(List<Evaluacion> lista)
        {
            string nombre;
            int suma = 0, porcentaje; 
             Console.WriteLine("-------Agregando Evaluación-------");
             Console.Write("Nombre: "); 
             nombre = Console.ReadLine();
            
             if (nombre.Length == 0) 
                 throw new EmptyException("El nombre está vacío.");
             Console.WriteLine("Introduce la cantidad de preguntas: ");
             int preguntas = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Introdcue el porcentaje: ");
            porcentaje = Convert.ToInt32(Console.ReadLine());
            
            if (suma + porcentaje <= 100)
            {
                suma += porcentaje;
                Console.WriteLine(suma);
                Parcial a = new Parcial(porcentaje,nombre,preguntas);
                lista.Add(a);
            }
            else
            {
                Console.WriteLine("Error, tiene que ser menor igual que 100.");
            }
           
        }
    }
}