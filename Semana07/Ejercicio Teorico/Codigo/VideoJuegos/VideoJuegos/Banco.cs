using System;
using VideoJuegos;

public static class Banco
{
    public static void registrarTarjeta()
    {
        Console.Write("Número de tarjeta: ");
        string numero = Console.ReadLine();


        if (GestorArchivos.Buscar("Tarjetas.txt", numero))
            throw new CardAlreadyCreatedException("Tarjeta ya encontrada");

        GestorArchivos.Anexar("Tarjetas.txt", numero);
        Console.WriteLine("Tarjeta creada exitosamente!");

    }

    
    public static void consultarTarjetas(){
        Console.WriteLine(GestorArchivos.Leer("Tarjetas.txt"));
    }
    
    public static bool realizarCompras(string tarjeta){
        return GestorArchivos.Buscar("Tarjetas.txt", tarjeta);
    }
}

    