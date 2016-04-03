using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class HistorialCargos
    {                
        private List<Cargo> cargos; // cargos históricos
        private List<string> fechaInicio; 
        private List<string> fechaFin;
        // private Departamento departamento; un empleado solo puede pertenecer a un departamento

        public HistorialCargos()
        {
            cargos = new List<Cargo>();
            fechaInicio = new List<string>();
            fechaFin = new List<string>();            
        }

        public void agregaCargo(Cargo cargo,string fechaInicio,string fechaFin)
        {
            cargos.Add(cargo);
            this.fechaInicio.Add(fechaInicio);
            this.fechaFin.Add(fechaFin);
        }

        public void imprimeHistorial()
        {
            Console.WriteLine("Cargos:");
            for (int i=0; i < cargos.Count; i++)
            {
                Console.WriteLine(i + ") " + cargos[i].Nombre);
            }
        }        
    }    
}
