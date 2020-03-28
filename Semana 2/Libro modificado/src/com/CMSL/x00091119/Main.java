package com.CMSL.x00091119;


import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    static Scanner sca = new Scanner(System.in);

    public static void main(String[] args) {
        ArrayList<Autor> autores = new ArrayList<>();
        ArrayList<Libro> libros = new ArrayList<>();

        String nombre,nombres, email;
        int paginas;
        char genero = 0;
        byte opGen;
        byte op;

        do {
            fMenu();
            op = sca.nextByte(); sca.nextLine();
            switch (op) {
                case 1:
                    System.out.println("-------Agregar Libro_--------");
                    System.out.println(" ");
                    System.out.println("Nombre del Libro: "); nombre = sca.nextLine();
                    System.out.println("Ingrese cantidad de paginas de su libro(Mayor que 1):"); paginas = sca.nextInt(); sca.nextLine();
                    libros.add(new Libro(paginas,nombre));

                    break;
                case 2:
                    System.out.println("-------Eliminar Libro_--------");
                    System.out.println("Ingresa el nombre del libro: "); nombre = sca.nextLine();

                    String finalNombre = nombre; sca.nextLine();
                    libros.removeIf( s -> s.getNombre().equals(finalNombre));

                    System.out.println("-------Su libro se elimino con éxito--------");

                    break;
                case 3:

                    System.out.println("-------Agregar Autor--------");
                    System.out.println(" ");
                    System.out.println("Nombre del Autor: "); nombres = sca.nextLine();
                    System.out.println("Ingrese genero:");
                    System.out.println("3.Ingrese '2' si es masculino y '3' si es femenino");
                    opGen = sca.nextByte(); sca.nextLine();
                    if(opGen == 2){
                        genero = 'm';
                    }
                    else if(opGen == 3){
                        genero = 'f';
                    }
                    else{
                        System.out.println("Opcion no valdia, solo se permite  '2' o '3' ");
                    }

                    System.out.println("Digite su email: "); email = sca.nextLine();
                    int con=0;

                    for(int i=0; i<email.length(); i++) {
                        if (email.charAt(i)=='@')
                            con++;
                    }
                    if((con==1)){
                        autores.add(new Autor(nombres, email, genero));
                    }
                    else {
                        System.out.println("Error, escribió mal el corro, falto colocar arroba.");
                    }
                    break;

                case 4:
                    System.out.println("-------Eliminar Autor_--------") ;
                    System.out.println("Ingresa el nombre del autor: "); nombres = sca.nextLine();

                    String finalAutor = nombres;
                    autores.removeIf( s -> s.getNombres().equals(finalAutor));

                    System.out.println("-------Su autor se eliminó con éxito--------");

                    break;

                case 5:
                    System.out.println(libros.toString());
                    break;

                case 6:
                    System.out.println(autores.toString());
                    break;
            }

        }while (op != 0) ;
    }

    public static void fMenu () {
        System.out.println("-----Presione el número de su opción deseada----");
        System.out.println("1. Agregar Libro.");
        System.out.println("2. Eliminar Libro.");
        System.out.println("3. Agregar autor.");
        System.out.println("4. Eliminar autor.");
        System.out.println("5. Mostrar Libros.");
        System.out.println("6. Mostrar Autores.");
        System.out.println("0. Salir.");
        System.out.print("Su opción elegida es: ");
    }

}
