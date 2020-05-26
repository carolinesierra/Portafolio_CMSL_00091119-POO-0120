using System;

namespace Icecreams_land
{
    public class Usuarios
    {
        
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public static bool admin { get; set; }
        public bool activo { get; set; }

        public Usuarios() { }

        public Usuarios( string pNombre, string pContrasena, 
            bool pAdmin,bool pActivo)
        {
            
            Nombre = pNombre;
            Contrasena = pContrasena;
            admin = pAdmin;
            activo = pActivo;
        }
    }
}