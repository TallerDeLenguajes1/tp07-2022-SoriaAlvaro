using System;
using System.Text.RegularExpressions;
using TareasClase;
using EmpleadosClase;
namespace tareasDeEmpleados{
    class Program{
       /*  static string IngresarDescrip(){
            Console.WriteLine("Ingrese una descripción");
            string descrip = Console.ReadLine();
            return descrip;
        }
        static int IngresarDuracion(){
            Console.WriteLine("Ingrese una duración de la tarea");
            int duracion = Convert.ToInt32(Console.ReadLine());
            return duracion;
        }

        static bool PreguntarTarea(){
            System.Console.WriteLine("Terminó la tarea?\n1)Y\n2)N");
            char op = Convert.ToChar(Console.ReadLine());
            return (op == 'y' || op == 'Y')?true
            :(op == 'n' || op == 'N')?false:false;
        }

        static void Mostar(List<Tareas> tar){
            foreach(Tareas tarea in tar){
                Console.WriteLine($"Tarea {tarea.TareaID}");
                Console.WriteLine($"Descripción {tarea.Descripcion}");
                Console.WriteLine($"Duración {tarea.Duracion}");
            }
        }

        static void AgregarTarea(List<Tareas> tar){
            System.Console.WriteLine("Ingrese una cantidad para registrar");
            int cant2 = Convert.ToInt32(Console.ReadLine());
            int cantTareas = tar.Count;
            for(int i =cantTareas; i < cant2+cantTareas; i++){
                tar.Add(new Tareas());
                tar[i].TareaID = i+1;
                tar[i].Descripcion = IngresarDescrip();
                tar[i].Duracion = IngresarDuracion();
                Console.Clear();
            }
        } */

        static bool Preguntar(){
            System.Console.WriteLine("Terminó la tarea?\nY SI\nCualquier otra tecla NO");
            char op = Convert.ToChar(Console.ReadLine());
            if(op == 'y' || op == 'Y'){
                return true;
            }
            return false;
        }
        static void Main(){

            /* ConsoleKeyInfo cki;
            List<Tareas> tareas = new List<Tareas>();
            List<Tareas> tareasR = new List<Tareas>();
                System.Console.WriteLine("Ingrese una cantidad para registrar");
                int cant = Convert.ToInt32(Console.ReadLine());
                for(var i = 0; i < cant; i++){
                    tareas.Add(new Tareas());
                    tareas[i].TareaID = i+1;
                    tareas[i].Descripcion = IngresarDescrip();
                    tareas[i].Duracion = IngresarDuracion();
                    Console.Clear();
                }
                System.Console.WriteLine($"num tareas {tareas.Count}");
            do{
                System.Console.WriteLine("1)Mostrar Tareas Pendientes\n2)Mover a tareas Realizadas\n3)Mostrar Tareas Realizadas\n4)Agregar Tareas");
                int op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if(op == 1){Mostar(tareas);}
                else if(op == 2){
                    for(int i = 0; i < tareas.Count; i++){
                        System.Console.WriteLine($"Tarea {tareas[i].TareaID}");
                        if(PreguntarTarea()){
                            tareasR.Add(tareas[i]);
                            tareas.RemoveAt(i);
                        }
                    }
                }
                else if(op == 3){Mostar(tareasR);}
                else if(op == 4){AgregarTarea(tareas);}
                else{System.Console.WriteLine("Ingrese una opción correcta");}
                System.Console.WriteLine("Presione ENTER para continuar");
                cki = Console.ReadKey();
                Console.Clear();
            }while(cki.Key != ConsoleKey.Escape); */

            /* Empleados newEmpleado = new Empleados();
            int cantTareas = 2;
            newEmpleado.AddData(cantTareas); */
            ConsoleKeyInfo cki;
            List<Empleados> tareasDeEmpleados = new List<Empleados>();
            tareasDeEmpleados.Add(new Empleados(0));
            tareasDeEmpleados[0].AddData();
            for(int i = 0; i < tareasDeEmpleados.Count; i++){
                System.Console.WriteLine($"Empleado {tareasDeEmpleados[0].EmpId}");
                System.Console.WriteLine($"Tareas del Empleado {tareasDeEmpleados[0].TareasEmpleado}");
                do{
                    System.Console.WriteLine("1)Mostrar Tareas Pendientes\n2)Mover Tareas\n3)Mostrar Tareas Realizadas");
                    int op = Convert.ToInt32(Console.ReadLine());
                    if(op == 1){
                        foreach(Tareas tar in tareasDeEmpleados[0].TareasPend){
                            System.Console.WriteLine($"Tarea {tar.TareaID}");
                            Console.WriteLine($"Descripción: {tar.Descripcion}");
                            Console.WriteLine($"Duración: {tar.Duracion}");
                        }
                    }
                    else if(op == 2){
                        for(int j = 0;j < tareasDeEmpleados[0].TareasPend.Count; j++){
                            if(Preguntar()){
                                tareasDeEmpleados[0].TareasRealz.Add(tareasDeEmpleados[0].TareasPend[j]);
                                tareasDeEmpleados[0].TareasPend.RemoveAt(j);
                            }
                        }
                    }
                    if(op == 3){
                        foreach(Tareas tar in tareasDeEmpleados[0].TareasRealz){
                            System.Console.WriteLine($"Tarea {tar.TareaID}");
                            Console.WriteLine($"Descripción: {tar.Descripcion}");
                            Console.WriteLine($"Duración: {tar.Duracion}");
                        }
                    }
                    cki = Console.ReadKey();
                    Console.Clear();
                }while(cki.Key != ConsoleKey.Escape);
            }
            Console.ReadKey();
        }
    }
}