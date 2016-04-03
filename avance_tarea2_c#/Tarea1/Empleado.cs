using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    
    class Empleado : Persona
    {
        private int codigo;
        private string fechaContratacion;
        private Departamento departamento;
        private float salario;
        private Cargo cargoActual;
        private HistorialCargos cargos;

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

        public string FechaContratacion
        {
            get
            {
                return fechaContratacion;
            }

            set
            {
                fechaContratacion = value;
            }
        }

        public float Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public Empleado(long dni, string nombres, string apellidoPat, string apellidoMat, string email, string telefono, string fechaNacimiento, int codigo, string fechaContratacion,float salario, GestorEmpleado gestorEmp, int numEmp) : base(dni, nombres, apellidoPat, apellidoMat, email, telefono, fechaNacimiento)
        {
            this.codigo = codigo;
            this.fechaContratacion = fechaContratacion;            
            this.salario = salario;

            /*Console.WriteLine("Ingrese los datos del departamento del empleado: ");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombDep = Console.ReadLine();
            departamento = new Departamento(id, nombDep,gestorEmp,numEmp);*/ // solo habrá un departamento

            
            Console.WriteLine("Ingrese los datos del cargo:");
            Console.Write("Codigo: ");
            int codCargo = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombCargo = Console.ReadLine();
            Console.Write("Salario minimo: ");
            float salarioMin = float.Parse(Console.ReadLine());
            Console.Write("Salario maximo: ");
            float salarioMax = float.Parse(Console.ReadLine());            
            cargoActual = new Cargo(codCargo,nombCargo,salarioMin,salarioMax);
            cargos = new HistorialCargos();            
            departamento = new Departamento(1, "Recursos Humanos", gestorEmp, numEmp);
        }

        //solo para cuando se crea un gerente
        public Empleado(long dni, string nombres, string apellidoPat, string apellidoMat, string email, string telefono, string fechaNacimiento, int codigo, string fechaContratacion, float salario,Departamento dep) : base(dni, nombres, apellidoPat, apellidoMat, email, telefono, fechaNacimiento)
        {
            /*Console.WriteLine("Ingrese los datos del cargo:");
            Console.Write("Codigo: ");
            int codCargo = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombCargo = Console.ReadLine();
            Console.Write("Salario minimo: ");
            float salarioMin = float.Parse(Console.ReadLine());
            Console.Write("Salario maximo: ");
            float salarioMax = float.Parse(Console.ReadLine());*/
            cargoActual = new Cargo(1,"Gerente",8000, 20000);
            cargos = new HistorialCargos();
            this.departamento = dep;
        } 

        public void imprimeDatos()
        {
            Console.WriteLine("Nombre: " + Nombres + " " + ApellidoPat + " " + ApellidoMat);
            Console.WriteLine("DNI: " + Dni);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Telefono: "+ Telefono);
            Console.WriteLine("Fecha de Nacimiento(dd/mm/aaaa): "+ FechaNacimiento);
            Console.WriteLine("Codigo de Empleado: " + codigo);
            Console.WriteLine("Fecha de Contratacion(dd/mm/aaaa): "+ fechaContratacion);
            Console.WriteLine("Departamento: "+ departamento);
            Console.WriteLine("Salario: "+ salario);
            cargos.imprimeHistorial();
            Console.WriteLine();
        }
    }

    
}
