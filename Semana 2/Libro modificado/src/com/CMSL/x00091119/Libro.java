package com.CMSL.x00091119;
public class Libro{
    private int  paginas, ISBN;
    private  String nombre;

    public Libro(int paginas, String nombre) {
        this.paginas = paginas;
        this.ISBN = GeneradorISBN.segundoISBN();
        this.nombre = nombre;
    }

    @Override
    public String toString() {
        return "ISBN: " + ISBN + " "+ nombre + " "+
                "(" + paginas + ") " ;
    }

    public int getISBN(){
        return ISBN;
    }

    public String getNombre(){
        return nombre;
    }

    public int getPaginas(){
        return paginas;
    }

}
