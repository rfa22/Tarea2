using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Persona
    {
        private long dni;
        private string nombres;
        private string apellidoPat;
        private string apellidoMat;                  
        private string email;
        private string telefono;
        private string fechaNacimiento;

        public Persona(long dni, string nombres, string apellidoPat, string apellidoMat, string email, string telefono, string fechaNacimiento)
        {
            this.dni = dni;
            this.nombres = nombres;
            this.apellidoPat = apellidoPat;
            this.apellidoMat = apellidoMat;
            this.email = email;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }

        public long Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string ApellidoPat
        {
            get
            {
                return apellidoPat;
            }

            set
            {
                apellidoPat = value;
            }
        }

        public string ApellidoMat
        {
            get
            {
                return apellidoMat;
            }

            set
            {
                apellidoMat = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }
    }
}
