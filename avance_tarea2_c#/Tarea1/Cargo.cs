using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Cargo
    {
        private int codigo;
        private string nombre;
        private float salarioMinimo;
        private float salarioMaximo;

        public Cargo(int codigo, string nombre, float salarioMinimo, float salarioMaximo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.salarioMinimo = salarioMinimo;
            this.salarioMaximo = salarioMaximo;
        }

        public void imprimeCargo()
        {
            Console.WriteLine("Codigo: " + codigo);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Salario Minimo: " + salarioMinimo);
            Console.WriteLine("Salario Maximo: " + salarioMaximo);
        }
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
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

        public float SalarioMinimo
        {
            get
            {
                return salarioMinimo;
            }

            set
            {
                salarioMinimo = value;
            }
        }

        public float SalarioMaximo
        {
            get
            {
                return salarioMaximo;
            }

            set
            {
                salarioMaximo = value;
            }
        }

        
    }


}
