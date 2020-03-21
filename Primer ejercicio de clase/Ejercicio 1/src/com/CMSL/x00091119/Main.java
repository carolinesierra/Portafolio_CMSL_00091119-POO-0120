package com.CMSL.x00091119;


public class Main {
    public static void main(String[] args) {
        System.out.println("<<<<<<<<<Laptop>>>>>>>>");
        Laptop DELL = new Laptop("DELL" ,"XPS 13",0 );

        DELL.encendiendo();
        System.out.println("\n");

        DELL.iniciarSesion("Caroline:)");
        System.out.println("\n");

        DELL.fotos();
        System.out.println("\n");
        //Setters
        Laptop.setFotos(34);
        System.out.println("Cantidad de fotos subidas: " + Laptop.getFotos());

        System.out.println("\n");
        DELL.apagaando();//Sin parametros
        DELL.apagaando("Caroline");


        // Para que se muestren separados
        System.out.println("\n");


        //Obteniendo valores de atributo con get
        System.out.println("Marca:" + Laptop.getMarca());
        System.out.println("Modelo: " + Laptop.getModelo());
        System.out.println("Fotos: " + Laptop.getFotos());

        System.out.println("\n");

        //Setters
        System.out.println("////Cambiando atributos.////");
        Laptop.setMarca("Apple");
        System.out.println("Nueva marca: " + Laptop.getMarca());
        Laptop.setModelo("MacBock");
        System.out.println("Nuevo modelo: " + Laptop.getModelo());


        ///////////////////////////System.out.println("Armario");/////////////////////////////////
        System.out.println("\n");
        System.out.println("<<<<<<<<<<<Armario>>>>>>>>>>");
        Armario Samsung = new Armario("Gucci", "S", 1 );

        Samsung.abriendo();
        System.out.println("\n");

        Samsung.iniciarSesion("Caroline:)");
        System.out.println("\n");

        Samsung.cantidad();
        System.out.println("\n");
        //Setters
        Armario.setCantidad(10);
        System.out.println("Cantidad de  prendas colocadas: " + Armario.getCantidad());

        System.out.println("\n");
        Samsung.cerrando();//Sin parametros
        Samsung.cerrando("Caroline");


        // Para que se muestren separados
        System.out.println("\n");


        //Obteniendo valores
        System.out.println("Marca:" + Armario.getMarcas());
        System.out.println("Tallas: " + Armario.getTalla());
        System.out.println("Prendas: " + Armario.getCantidad());

        System.out.println("\n");

        //Setters
        System.out.println("////Cambiando atributos///.");
        Armario.setMarcas("Apple");
        System.out.println("Nueva marca de tu armario: " + Armario.getMarcas());
        Armario.setTalla("M");
        System.out.println("Nueva talla de tus prendas: " + Armario.getTalla());
        Armario.setCantidad(20);
        System.out.println("Cantidad de nuevas prendas colocadas: " + Armario.getCantidad());
    }











}

