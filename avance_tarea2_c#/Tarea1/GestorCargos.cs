using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class GestorCargos
    {
        private List<Cargo> listaCargos;

        public GestorCargos()
        {
            listaCargos = new List<Cargo>();
        }

        public Cargo this[int indice]
        {
            get
            {
                if (indice >= listaCargos.Count || indice < 0)
                    return null;
                else
                    return listaCargos[indice];
            }
            set
            {
                if (indice >= 0 && indice < listaCargos.Count)
                    listaCargos[indice] = value;
                else
                {
                    if (indice == listaCargos.Count)
                        listaCargos.Add(value);
                    else
                        throw new Exception("No se puede asignar a este cargo");
                }
            }
        }

        public bool buscarCargo(int cod)
        {
            for (int i = 0; i < listaCargos.Count; i++)
            {
                if (listaCargos[i].Codigo == cod)
                {
                    return true; // el cargo ya está creado
                }
            }
            return false; // si llegó al final y no lo encontró, no estaría creado
        }

        public void mostrarCargos()
        {
            if (listaCargos.Count > 0)
            {
                for (int i = 0; i < listaCargos.Count; i++)
                {
                    listaCargos[i].imprimeCargo();
                }
            }
            else
            {
                Console.WriteLine("No hay cargos registrados.");
            }
        }
    }
}
