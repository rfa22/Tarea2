using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numEmp = 0;
            int numCar = 0;
            GestorEmpleado gestorEmp = new GestorEmpleado();
            GestorCargos gestorCar = new GestorCargos();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de Opciones");
                Console.WriteLine("1.- Crear una Locacion");
                Console.WriteLine("2.- Crear una Departamento");
                Console.WriteLine("3.- Crear un Empleado");
                Console.WriteLine("4.- Crear un Cargo");
                Console.WriteLine("5.- Mostrar Empleados");
                Console.WriteLine("6.- Mostrar Cargos");
                Console.WriteLine("7.- Mostrar Empleado");
                Console.WriteLine("8.- Editar Empleado");
                Console.Write("Ingrese su opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Write("Ingrese Id: ");
                            int id = int.Parse(Console.ReadLine());
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
                            Locacion locacion = new Locacion(id, direccion, codigoPostal, ciudad, provincia, estado, pais, region);
                            Console.WriteLine("El objeto Locacion ha sido creado correctamente");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Ingrese Id: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese Nombre: ");
                            string nombre = Console.ReadLine();
                            Departamento departamento = new Departamento(id, nombre, gestorEmp, numEmp);
                            Console.WriteLine("El objeto Departamento ha sido creado correctamente");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Codigo de Empleado: ");
                            int codEmp = int.Parse(Console.ReadLine());
                            bool existeEmpleado = gestorEmp.buscarEmpleado(codEmp,0);
                            if (!existeEmpleado)
                            {
                                Console.Write("Nombre(s): ");
                                string nombre = Console.ReadLine();
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
                                Empleado emp = new Empleado(dni, nombre, apellidoPat, apellidoMat, email, telefono, fechaNacimiento, codEmp, fechaContrat, salario, gestorEmp, numEmp);
                                gestorEmp[numEmp] = emp;
                                numEmp++;   //no se pide los datos del gerente, solo se crea un empleado 
                                //numEmp += 2; // se crea un gerente también por el departamento.. se tiene que ver si ya existe el gerente antes (tema a completar)
                            }
                            else
                            {
                                Console.WriteLine("El empleado ya existe.");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Codigo: ");
                            int codCargo = int.Parse(Console.ReadLine());
                            bool existeCargo = gestorCar.buscarCargo(codCargo);
                            if (!existeCargo)
                            {
                                Console.Write("Nombre: ");
                                string nombCargo = Console.ReadLine();
                                Console.Write("Salario Minimo: ");
                                float salarioMin = float.Parse(Console.ReadLine());
                                Console.Write("Salario Maximo: ");
                                float salarioMax = float.Parse(Console.ReadLine());
                                Cargo cargo = new Cargo(codCargo, nombCargo, salarioMin, salarioMax);
                                gestorCar[numCar] = cargo;
                                numCar++;
                            }
                            else
                            {
                                Console.WriteLine("El cargo ya existe.");
                            }
                            break;
                        }
                    case 5:
                        {
                            gestorEmp.mostrarEmpleados();
                            break;
                        }
                    case 6:
                        {
                            gestorCar.mostrarCargos();
                            break;
                        }
                    case 7: //Mostrar Empleado segun codigo
                        {
                            Console.Write("Ingrese el codigo del empleado: ");
                            int codEmp = int.Parse(Console.ReadLine());
                            bool existeEmpleado = gestorEmp.buscarEmpleado(codEmp,1);                            
                            if(!existeEmpleado) Console.WriteLine("El empleado no existe");
                            break;
                        }
                    case 8: //Editar Empleado
                        {
                            Console.WriteLine("Ingrese el codigo del empleado: ");
                            int codEmp = int.Parse(Console.ReadLine());
                            int lala;
                            break;
                        }
                }
                //Esto es para evitar que la pantalla de salida se cierre automaticamente.
                Console.ReadLine();
            }
        }
    }
}
