using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Locacion
    {
        private int id;
        private string direccion;
        private int codigoPostal;
        private string ciudad;
        private string provincia;
        private string estado;
        private string pais;
        private string region;

        public Locacion(int id, string direccion, int codigoPostal, string ciudad, string provincia, string estado, string pais, string region)
        {
            this.id = id;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.ciudad = ciudad;
            this.provincia = provincia;
            this.estado = estado;
            this.pais = pais;
            this.region = region;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int CodigoPostal
        {
            get
            {
                return codigoPostal;
            }

            set
            {
                codigoPostal = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }

        
    }
}
