using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    internal static class Program
    {    
       static List<Evaluacion> ev  = new List<Evaluacion>();
       private static int suma = 0, porcentaje = 0;
       public static void Main(string[] args)
       {
           string nombre, tipo;
           int opc, preguntas,opcion = 0;
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
                               Console.WriteLine("-------Agregando Evaluación-------");
                               Console.Write("Nombre: "); 
                               nombre = Console.ReadLine();
                               if (nombre.Length == 0)
                                   throw new EmptyException("El nombre está vacío.");
                               if (ExisteEvaluacion(nombre))
                                   throw new ExistException("La evaluación ya existe.");
                               Console.WriteLine(
                                   "Elija que tipo de evaluación necesita \n1. Tarea  2. Parcial  3. Laboratorio: ");
                               opc = Convert.ToInt32(Console.ReadLine());
                               if (suma <= 100)
                               {
                                   switch (opc)
                                   {
                                       case 1:
                                           Console.WriteLine(
                                               "Ingrese la fecha de entrega de la siguiente forma (día-mes-año): ");
                                           String fecha = Console.ReadLine();
                                           var fecha2 = DateTime.Parse(fecha);
                                           Console.WriteLine("Introdcue el porcentaje: ");
                                           porcentaje = Convert.ToInt32(Console.ReadLine());
                                           if (suma + porcentaje <= 100)
                                           {
                                               suma += porcentaje;
                                               Console.WriteLine(suma);

                                               ev.Add(new Tarea(porcentaje, nombre, fecha2));
                                           }
                                           else
                                           {
                                               Console.WriteLine(
                                                   "Error, tiene que ser menor o igual que 100.");
                                           }

                                           break;
                                       case 2:
                                           Console.WriteLine("Introduce la cantidad de preguntas: ");
                                           preguntas = Convert.ToInt32(Console.ReadLine());
                                           Console.WriteLine("Introdcue el porcentaje: ");
                                           porcentaje = Convert.ToInt32(Console.ReadLine());
                                           if (suma + porcentaje <= 100)
                                           {
                                               suma += porcentaje;
                                               Console.WriteLine(suma);
                                               ev.Add(new Parcial(porcentaje, nombre, preguntas));
                                           }
                                           else
                                           {
                                               Console.WriteLine("Error, tiene que ser menor igual que 100.");
                                           }

                                           break;
                                       case 3:
                                           Console.WriteLine("Tipo: ");
                                           tipo = Console.ReadLine();
                                           Console.WriteLine("Introdcue el porcentaje: ");
                                           porcentaje = Convert.ToInt32(Console.ReadLine());
                                           if (suma + porcentaje <= 100)
                                           {
                                               suma += porcentaje;
                                               Console.WriteLine(suma);

                                               ev.Add(new Laboratorio(porcentaje, nombre, tipo));
                                           }
                                           else
                                           {
                                               Console.WriteLine("Error, tiene que ser menor o igual que 100.");
                                           }

                                           break;
                                   }
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
                               catch (EvaluationNonExistentException e)
                               {
                                   Console.WriteLine(e.Message);
                               }
                               catch (EmptyException e)
                               {
                                   Console.WriteLine(e);
                               }

                               break;
                           case 4:
                               try
                               {
                                   Calculadora();
                               }
                               catch (InvalidDataException e)
                               {
                                   Console.WriteLine(e.Message);
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
                  if (eliminando != null)
                      throw new EvaluationNonExistentException("No existe dicha evaluación.");

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


              public static void Calculadora()
              {
                  
                  calcularNota.Calcular(new List<Evaluacion>());
                  double total = calcularNota.Calcular(ev); /////////preguntar
                           
                  if(total <= 10)
                      throw new InvalidDataException("Tiene que ser menor o igual que 10.");
                  Console.WriteLine("-------Mostrando Promedio-------");
                  Console.WriteLine(total);
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

              public static bool ExisteEvaluacion(String nombre)
              {
                  foreach (var evaluacion in ev)
                  {
                      if (evaluacion.Nombre.Equals(nombre))
                      {
                          return true;
                      }
                  }
                  return false;
              }
    }
}
