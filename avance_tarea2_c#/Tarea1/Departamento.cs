using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Departamento
    {
        private int id;
        private string nombre;
        private Locacion sede;
        private Empleado gerente;

        //Aquí estoy definiendo un constructor para la clase Departamento, recuerde que los constructores
        //deben ser publicos para que puedan ser utilizados para instanciar objetos.
        public Departamento(int id, string nombre,GestorEmpleado gestorEmp,int numEmp)
        {
            this.id = id;
            this.nombre = nombre;
            
            //Ahora pediremos los datos de locacion para el objeto sede que es dato miembro de esta clase.
            Console.WriteLine("Ingrese los datos de la Locacion: ");
            Console.Write("Ingrese Id: ");
            int idLocacion = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Direccion: ");
            string direccion = Console.ReadLine();
            Console.Write("Ingrese CodigoPostal: ");
            int codigoPostal = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Ciudad: ");
            string ciudad = Console.ReadLine();
            Console.Write("Ingrese Provincia: ");
            string provincia = Console.ReadLine();
            Console.Write("Ingrese Estado: ");
            string estado = Console.ReadLine();
            Console.Write("Ingrese Pais: ");
            string pais = Console.ReadLine();
            Console.Write("Ingrese Region: ");
            string region = Console.ReadLine();
            //Con estos datos llamamos al constructor de locación para crear el objeto sede.
            this.sede = new Locacion(idLocacion, direccion, codigoPostal, ciudad, provincia, estado, pais, region);

            Console.WriteLine("Ingrese los datos del gerente del departamento: ");
            Console.Write("Codigo de Empleado: ");
            int codEmp = int.Parse(Console.ReadLine());            
            Console.Write("Nombre(s): ");
            string nombGer = Console.ReadLine();
            Console.Write("Apellido Paterno: ");
            string apellidoPat = Console.ReadLine();
            Console.Write("Apellido Materno: ");
            string apellidoMat = Console.ReadLine();
            Console.Write("DNI: ");
            long dni = long.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefono: ");
            string telefono = Console.ReadLine();
            Console.Write("Fecha de Nacimiento(dd/mm/aaaa): ");
            string fechaNacimiento = Console.ReadLine();            
            Console.Write("Fecha de Contratacion(dd/mm/aaaa): ");
            string fechaContrat = Console.ReadLine();
            Console.Write("Salario: ");            
            float salario = float.Parse(Console.ReadLine());
            this.gerente = new Empleado(dni, nombGer, apellidoPat, apellidoMat, email, telefono, fechaNacimiento, codEmp, fechaContrat, salario,this);
            gestorEmp[numEmp] = this.gerente;
        }

    }
}
