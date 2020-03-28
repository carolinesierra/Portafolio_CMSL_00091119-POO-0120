package com.CMSL.x00091119;
public class Libro {
    private int  paginas;
    private  String nombre, ISBN;

    public Libro(int paginas, String nombre, String ISBN) {
        this.paginas = paginas;
        this.nombre = nombre;
        this.ISBN = ISBN;
    }

    @Override
    public String toString() {
        return "ISBN: " + ISBN + " "+ nombre + " "+
                "(" + paginas + ") " ;
    }
    public String getISBN(){
        return ISBN;
    }

    public String getNombre(){
        return nombre;
    }

    public int getPaginas(){
        return paginas;
    }

}
