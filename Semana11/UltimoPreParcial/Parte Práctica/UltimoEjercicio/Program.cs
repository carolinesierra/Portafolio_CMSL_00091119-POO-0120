using System;
using System.Collections.Generic;

namespace UltimoEjercicio
{
    internal class Program
    {
        static List<Evaluacion> ev  = new List<Evaluacion>();
        static IEvaluation misEvaluaciones = new NuevParcial();
        private static int suma = 0, porcentaje = 0;
        public static void Main(string[] args)
        {
            int opc, opcion;
           bool continuar = true;

          
               do
               {
                   Console.Write(MenuUno());
                   try
                   {
                       opcion = Convert.ToInt32(Console.ReadLine());
                       switch (opcion)
                       {
                           case 1:
                               Console.WriteLine(
                                   "Elija que tipo de evaluación necesita \n1. Tarea  2. Parcial  3. Laboratorio: ");
                               opc = Convert.ToInt32(Console.ReadLine());
                               if (suma <= 100)
                               {
                                   switch (opc)
                                   {
                                       case 1:
                                           misEvaluaciones = new NuevTarea();
                                           break;
                                       case 2:
                                           misEvaluaciones = new NuevParcial();
                                           break;
                                       case 3:
                                           misEvaluaciones = new NuevLaboratorio();
                                           break;
                                   }

                                   misEvaluaciones.evaluaciones(ev);
                               }
                               else
                               {
                                   Console.WriteLine("Error.");
                               }

                               break;
                           case 2:
                               MostrandoEv();
                               break;
                           case 3:
                               try
                               {
                                   ElimnandoEv();
                               }
                               catch (EmptyException e)
                               {
                                   Console.WriteLine(e);
                               }

                               break;
                           case 4:
                               CalcularNota.Calcular(new List<Evaluacion>());
                               double total = CalcularNota.Calcular(ev);

                               if (total <= 10)
                               {
                                   Console.WriteLine("-------Mostrando Promedio-------");
                                   Console.WriteLine(total);
                               }
                               else
                               {
                                   Console.WriteLine("Error, tiene que ser igual o menor que 10.");
                               }

                               continuar = false;
                               break;
                           default:
                               Console.WriteLine("Opcion errónea!");
                               break;
                       }
                   }
                   catch (FormatException e)
                   {
                       Console.WriteLine(e.Message);
                       opcion = 99;
                   }
                   catch (EmptyException e)
                   {
                       Console.WriteLine(e.Message);
                   }
                  

               } while (continuar);

               Console.WriteLine("\nGracias por preferirnos, que tenga un buen día:)!");
           
       }
        static String MenuUno(){
            return "\nBienvenido:\n" +
                   "1) Agregar Evaluaion.\n" +
                   "2) Mostrar evaluaiones almacenadas.\n" +
                   "3) Eliminar evaluaion.\n" +
                   "4) Salir.\n" +
                   "Opción elegida: ";
        }
        private static void ElimnandoEv()
        {
            Console.WriteLine("-------Eliminando Evaluación-------");
            Console.WriteLine("Nombre de la evaluacion a eliminar: ");
            String eliminando = Console.ReadLine();
            if (eliminando != null && eliminando.Length == 0)
                throw new EmptyException("El nombre está vacío.");
            
            foreach (var p in ev)
            {
                if (p.Nombre == eliminando)
                {
                    suma -= p.Porcentaje;
                }
            }
            ev.RemoveAll(p => p.Nombre == eliminando);
            Console.WriteLine("Evaluación eliminada:(");
        }

        private static void MostrandoEv()
        {
            foreach (var p in ev)
            {
                Console.WriteLine("-------Mostrando Evaluaciones-------");
                Console.WriteLine("Nombre: " + p.Nombre);
                Console.WriteLine("Porcentaje:  " + p.Porcentaje);
                      
                if (p is Tarea)
                {
                    Tarea t1 = (Tarea) p;
                    Console.WriteLine("Fecha de entrega: " + t1.FechaEntrega.ToShortDateString());
                }
            }
        }
    }
    }
