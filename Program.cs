using System;
using EmpleadosClase;

namespace tareasDeEmpleados{
    class Program{
        static string IngresarDescrip(){
            Console.WriteLine("Ingrese una descripción");
            return Console.ReadLine();
        }
        static int IngresarDuracion(){
            Console.WriteLine("Ingrese una duración de la tarea");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(){
            List<Empleado> emp = new List<Empleado>();
            System.Console.WriteLine("Ingrese una cantidad para registrar");
            int cant = Convert.ToInt32(Console.ReadLine());
            for(var i = 0; i < cant; i++){
                emp.Add(new Empleado() {TareaID = i+1,Descripcion = IngresarDescrip(), Duracion = IngresarDuracion()});
                Console.Clear();
            }
            foreach(Empleado empl in emp){
                Console.WriteLine($"Id tarea: {empl.TareaID}");
                Console.WriteLine($"Descripción: {empl.Descripcion}");
                Console.WriteLine($"Duración: {empl.Duracion}");
                Console.WriteLine();
            }
        }
    }
}