﻿namespace UltimoEjercicio
{
    public class Parcial : Evaluacion
    {
        private int cantPreguntas;

        public Parcial(int porcentaje, string nombre, int cantPreguntas) : base(porcentaje, nombre)
        {
            this.cantPreguntas = cantPreguntas;
        }

        public override string ToString()
        {
            return $"{nameof(cantPreguntas)}: {cantPreguntas}";
        }
        
    }
}