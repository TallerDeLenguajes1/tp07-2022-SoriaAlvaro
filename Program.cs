using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasClase;
using EmpleadosClase;
namespace tareasDeEmpleados{
    class Program{
        static bool Preguntar(){
            Console.WriteLine("Terminó la tarea?\ny/Y para CONFIRMAR.");
            Console.WriteLine("");
            char opConfirm = Convert.ToChar(value: Console.ReadLine());
            Console.ReadKey();
            do{
                if(!((opConfirm == 'y' || opConfirm == 'Y') || (opConfirm == 'n' || opConfirm == 'N'))){
                    Console.WriteLine("Ingrese una Opción correcta");
                }
                else{
                    if(opConfirm == 'y' || opConfirm == 'Y'){
                        return true;
                    }else if(opConfirm == 'n' || opConfirm == 'N'){
                        return false;
                    }
                }
            }while(!((opConfirm == 'y' || opConfirm == 'Y') || (opConfirm == 'n' || opConfirm == 'N')));
            return false;
        }
        static void Main(string[] args){
            //Lista de Empleados
            List<Empleados>listasDeEmpleados= new List<Empleados>();
            Random rand = new Random();
            int rEmpleado = rand.Next(1,3);
            int cantTar = 0;
            Console.WriteLine($"Total de empleados = {rEmpleado}");
            for(int i = 0; i < rEmpleado; i++){
                listasDeEmpleados.Add(new Empleados(i));
                Console.WriteLine($"Empleado: {listasDeEmpleados[i].EmpId}");
                Console.WriteLine($"Tareas del empleado: {listasDeEmpleados[i].CanTareasEmp}");
                cantTar = listasDeEmpleados[i].CanTareasEmp;
                listasDeEmpleados[i].TareasDelEmpleado = new List<Tareas>();//lista de tareas del empleado
                listasDeEmpleados[i].TareasDelEmpleadoRealizadas = new List<Tareas>();
                for(int j = 0; j < cantTar; j++){
                    listasDeEmpleados[i].TareasDelEmpleado.Add(new Tareas());
                    listasDeEmpleados[i].TareasDelEmpleado[j].TareaID = j+1;
                    System.Console.WriteLine($"Descripción de tarea {listasDeEmpleados[i].TareasDelEmpleado[j].TareaID}:");
                    listasDeEmpleados[i].TareasDelEmpleado[j].Descripcion = Console.ReadLine();
                    System.Console.WriteLine("Duración: ");
                    listasDeEmpleados[i].TareasDelEmpleado[j].Duracion = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("");
                }
                System.Console.WriteLine("\n===\t===\t===\t===\t===\t===\t===\t===\t===\t\n");
                Console.Clear();
            }

            ConsoleKeyInfo cki;
            do{
                Console.WriteLine("1)Mostrar Tareas\n2)Mover Tareas\n3)Mostrar Realizadas");
                int op = Convert.ToInt32(Console.ReadLine());
                if(op == 1){
                    foreach(Empleados emp in listasDeEmpleados){
                        Console.WriteLine("");
                        Console.WriteLine($"Tareas pendientes del Empleado {emp.EmpId}");
                        Console.WriteLine($"Cantidad de tareas= {emp.CanTareasEmp}");
                        Console.WriteLine("");
                        foreach(Tareas tar in emp.TareasDelEmpleado){
                            Console.WriteLine($"Tarea {tar.TareaID}");
                            Console.WriteLine($"Descripción: {tar.Descripcion}");
                            Console.WriteLine($"Duración: {tar.Duracion}");
                            Console.WriteLine("");
                        }
                        Console.WriteLine("\n===\t===\t===\t===\t===\t===\t===\t===\t===\t\n");
                    }
                }
                if(op == 2){
                    for(int i = 0; i < rEmpleado; i++){
                        Console.WriteLine($"Empleado: {listasDeEmpleados[i].EmpId}");
                        Console.WriteLine($"Tareas del empleado: {listasDeEmpleados[i].CanTareasEmp}");
                        cantTar = listasDeEmpleados[i].CanTareasEmp;
                        for(int j = 0; j < cantTar; j++){
                             /* Console.WriteLine($"Tarea {listasDeEmpleados[i].TareasDelEmpleado[j].TareaID}:"); */
                            if(Preguntar()){
                                listasDeEmpleados[i].TareasDelEmpleadoRealizadas.Add(listasDeEmpleados[i].TareasDelEmpleado[j]);
                                listasDeEmpleados[i].CanTareasEmp -= 1;
                                if(listasDeEmpleados[i].CanTareasEmp < 0){listasDeEmpleados[i].CanTareasEmp = 0;}
                                listasDeEmpleados[i].TareasDelEmpleado.RemoveAt(j);
                            }
                            else{continue;}
                        }
                    }
                }
                if(op == 3){
                    foreach(Empleados emp in listasDeEmpleados){
                        Console.WriteLine("");
                        Console.WriteLine($"Tareas pendientes del Empleado {emp.EmpId}");
                        Console.WriteLine($"Cantidad de tareas= {emp.CanTareasEmp}");
                        Console.WriteLine("");
                        foreach(Tareas tar in emp.TareasDelEmpleadoRealizadas){
                            Console.WriteLine($"Tarea {tar.TareaID}");
                            Console.WriteLine($"Descripción: {tar.Descripcion}");
                            Console.WriteLine($"Duración: {tar.Duracion}");
                            Console.WriteLine("");
                        }
                        Console.WriteLine("\n===\t===\t===\t===\t===\t===\t===\t===\t===\t\n");
                    }
                }
                cki = Console.ReadKey();
                Console.Clear();
            }while(cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}