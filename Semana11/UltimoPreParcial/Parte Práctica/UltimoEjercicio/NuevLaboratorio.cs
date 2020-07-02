using System;
using System.Collections.Generic;

namespace UltimoEjercicio
{
    public class NuevLaboratorio : IEvaluation
    {
        public void evaluaciones(List<Evaluacion> lista)
        {
            string nombre, tipo;
            int porcentaje, suma = 0; 
            Console.WriteLine("-------Agregando Evaluación-------");
            Console.Write("Nombre: "); 
            nombre = Console.ReadLine();
            if (nombre.Length == 0) 
                throw new EmptyException("El nombre está vacío.");
           
            
            Console.WriteLine("Tipo: ");
            tipo = Console.ReadLine();
            Console.WriteLine("Introdcue el porcentaje: ");
            porcentaje = Convert.ToInt32(Console.ReadLine());
            if (suma + porcentaje <= 100)
            {
                suma += porcentaje;
                Console.WriteLine(suma);

                Laboratorio a = new Laboratorio(porcentaje,nombre,tipo);
                lista.Add(a);
            }
            else
            {
                Console.WriteLine("Error, tiene que ser menor o igual que 100.");
            }

        }
    }
}