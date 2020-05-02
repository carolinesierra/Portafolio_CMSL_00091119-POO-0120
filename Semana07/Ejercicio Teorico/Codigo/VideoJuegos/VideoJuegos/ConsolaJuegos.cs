using System;
using VideoJuegos;

public static class ConsolaJuegos{
    public static void comprarJuego(){
        Console.Write("Número de tarjeta: ");
        string numero = Console.ReadLine();

        if (Banco.realizarCompras(numero))
        {
            Console.Write("Nombre del juego: ");
            string juego = Console.ReadLine();

           
            if (GestorArchivos.Buscar("Juegos.txt", juego))
                throw new GameCreatedException("No puede comprar el mismo juego.");

            GestorArchivos.Anexar("Juegos.txt", juego);
            Console.WriteLine("Juego comprado exitosamente!");
        }

    }

    public static void ConsultarJuegos()
    {
        Console.WriteLine(GestorArchivos.Leer("Juegos.txt"));
    }
    public static void jugar(){
        Console.Write("Nombre del juego: ");
        string juego = Console.ReadLine();
        
        if(GestorArchivos.Buscar("Juegos.txt", juego))
            Console.WriteLine("Listo para jugar!");
        else
            Console.WriteLine("Primero debe comprar el juego :(");
    }
}