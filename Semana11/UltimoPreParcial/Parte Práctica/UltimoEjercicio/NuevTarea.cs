using System;
using System.Collections.Generic;

namespace UltimoEjercicio
{
    public  class NuevTarea : IEvaluation
    {
        public void evaluaciones(List<Evaluacion> lista)
        {
            int porcentaje;
            string nombre;
            
            Console.WriteLine("-------Agregando Evaluación-------");
            Console.Write("Nombre: "); 
            nombre = Console.ReadLine();
            if (nombre.Length == 0)
                throw new EmptyException("El nombre está vacío.");
            Console.WriteLine(
                "Ingrese la fecha de entrega de la siguiente forma (día-mes-año): ");
            String fecha = Console.ReadLine();
            var fecha2 = DateTime.Parse(fecha);
            
            Console.WriteLine("Introdcue el porcentaje: ");
            porcentaje = Convert.ToInt32(Console.ReadLine());
            
            int suma = 0;
            if (suma + porcentaje <= 100)
            {
                suma += porcentaje;
               Console.WriteLine(suma);
             Tarea a = new Tarea(porcentaje,nombre, fecha2);
             lista.Add(a);
            }
            else
            {
                Console.WriteLine(
                    "Error, tiene que ser menor o igual que 100.");
            }
        }
    }
}