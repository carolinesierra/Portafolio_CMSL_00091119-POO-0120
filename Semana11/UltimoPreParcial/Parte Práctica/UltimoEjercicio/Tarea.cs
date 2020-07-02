using System;
namespace UltimoEjercicio
{
    public class Tarea : Evaluacion
    {
        private DateTime fechaEntrega;
        

        public DateTime FechaEntrega => fechaEntrega;



        public Tarea(int porcentaje, string nombre, DateTime fechaEntrega) : base(porcentaje, nombre)
        {
            this.fechaEntrega = fechaEntrega;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(fechaEntrega)}: {fechaEntrega}, {nameof(FechaEntrega)}: {FechaEntrega}";
        }
        
    }
}