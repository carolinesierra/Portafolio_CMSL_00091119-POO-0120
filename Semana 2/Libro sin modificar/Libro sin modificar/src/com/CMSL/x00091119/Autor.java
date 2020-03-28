package com.CMSL.x00091119;

public class Autor {
    private String nombres, email;
    private char genero;


    public Autor(String nombre, String email, char genero) {
        this.nombres = nombre;
        this.email = email;
        this.genero = genero;
    }

    @Override
    public String toString() {
        return   nombres +" " +
                "(" + genero + ")" + ": " +
                email + " ";
    }

    public String getNombres(){
        return  nombres;
    }
    public String getEmail(){
        return email;
    }
    public char getGenero(){
        return genero;
    }




}
