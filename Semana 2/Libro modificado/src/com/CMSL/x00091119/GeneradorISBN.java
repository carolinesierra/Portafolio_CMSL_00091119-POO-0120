package com.CMSL.x00091119;

public class GeneradorISBN {
    private static int cont = 0;

    private GeneradorISBN() {

    }
    public static int segundoISBN() {
        cont++;
        return cont;
    }
}