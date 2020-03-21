package com.CMSL.x00091119;

public class Armario {

    private static String marcas, talla;
    private static int cantidad;

    public Armario(String marcas, String talla, int cantidad) {
        Armario.marcas = marcas;
        Armario.talla = talla;
        Armario.cantidad = cantidad;
    }

    public void abriendo() {
        System.out.println("Su armario " + marcas + " se está abriendo...");
        System.out.println("Su armario se abrio completamente:D");
    }

    public void cantidad() {
        System.out.println("Colocando prendas, espere un momento por favor...");
        System.out.println("Prendas colocadas correctamente:O!");
    }
    public void cerrando() {
        System.out.println("Se cerrara su armario...");
    }
    public void cerrando(String usuario){
        System.out.println("Su armario " + marcas +" se está cerrando " + usuario + "...");
        System.out.println("Su armario se ha cerrado:(.");
    }
    public void iniciarSesion(String usuario) {
        System.out.println("Bienvenida: " + usuario + ". Un gusto volver a verte");
        System.out.println("Se ha iniciado sesión correctamente:D!");
    }
    // Setters del atributo Marca
    public static void setMarcas(String tMarcas){
        marcas = tMarcas;
    }
    public static void setTalla(String tTalla){
        talla = tTalla;
    }
    public static void setCantidad(int tCantidad){
        cantidad = tCantidad;
    }
    //GET
    public static String getMarcas(){
        return marcas;
    }
    public static String getTalla(){
        return talla;
    }
    public static int getCantidad(){
        return cantidad;
    }
}












