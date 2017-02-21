using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Encargado
    {
        private String cedula;
        private String nombre;
        private String apellido;
        private String apellidoDos;
        private int telefono;
        private String correo;
        private String direccion;

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string ApellidoDos
        {
            get
            {
                return apellidoDos;
            }

            set
            {
                apellidoDos = value;
            }
        }
    }
}
