using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class GestorEmpleado
    {

        private List<Empleado> listaEmpleado;

        public GestorEmpleado()
        {
            listaEmpleado = new List<Empleado>();
        }

        public Empleado this[int indice]
        {
            get
            {
                if (indice >= listaEmpleado.Count || indice < 0)
                    return null;
                else
                    return listaEmpleado[indice];
            }
            set
            {
                if (indice >= 0 && indice < listaEmpleado.Count)
                    listaEmpleado[indice] = value;
                else
                {
                    if (indice == listaEmpleado.Count)
                        listaEmpleado.Add(value);                    
                    else
                        throw new Exception("No se puede asignar a este empleado");
                }
            }
        }

        public bool buscarEmpleado(int cod, int imprime)
        {
            for(int i=0; i<listaEmpleado.Count; i++)
            {
                if(listaEmpleado[i].Codigo == cod)
                {
                    if (imprime == 1)
                        listaEmpleado[i].imprimeDatos();
                    return true; // el empleado ya está creado
                }                
            }
            return false; // si llegó al final y no lo encontró, no estaría creado
        }
                       
        public void mostrarEmpleados()
        {
            if (listaEmpleado.Count > 0)
            {
                for (int i = 0; i < listaEmpleado.Count; i++)
                {
                    listaEmpleado[i].imprimeDatos();
                }
            }
            else
            {
                Console.WriteLine("No hay empleados registrados");
            }
        }
    }
}
