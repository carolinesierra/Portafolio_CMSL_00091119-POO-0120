package com.CMSL.x00091119;

public class Laptop {

    private static String marca, modelo;
    private static int fotos;


    public Laptop(String marca, String modelo, int fotos) {
        Laptop.marca = marca;
        Laptop.modelo = modelo;
        Laptop.fotos = fotos;
    }
    public void encendiendo() {
        System.out.println("Su laptop " + marca + " " + modelo + " " + " se está encendiendo...");
        System.out.println("Su laptop se ha encendido correctamente!");
    }

    public void fotos() {
        System.out.println("Subiendo fotos, espere un momento por favor...");
        System.out.println("Fotos subidas perfectamente :D!");
    }

    public void apagaando() {
        System.out.println("Se apagará el equipo...");
    }
    public void apagaando(String usuario){
        System.out.println("Su laptop " + marca + " " + modelo + " " + " se está apagando " + usuario + "...");
        System.out.println("Su laptop se ha apagado!");
    }

    public void iniciarSesion(String usuario) {
        System.out.println("Bienvenida: " + usuario + ". Un gusto volver a verte:)");
        System.out.println("Se ha iniciado sesión correctamente:D!");
    }
    // Setters del atributo Marca
    public static void setMarca(String tMarca){
        marca = tMarca;
    }
    public static void setModelo(String tModelo){
        modelo = tModelo;
    }
    public static void setFotos(int tFotos){
        fotos=tFotos;
    }
    //getters del atributo Marca
    public static String getMarca(){
        return marca;
    }
    public static String getModelo(){
        return modelo;
    }
    public static int getFotos(){
        return fotos;
    }

}

