using System;
using System.Diagnostics;
using TareasClase;
namespace EmpleadosClase{
    public class Empleados{
        private Tareas tareas;
        private List <Tareas> tareasPend;
        private List <Tareas> tareasRealz;
        private int tareasEmpleado;
        private Random newRandom = new Random();
        private int empId;
        public List<Tareas> TareasPend { get => tareasPend; set => tareasPend = value; }
        public List<Tareas> TareasRealz { get => tareasRealz; set => tareasRealz = value; }
        public int TareasEmpleado { get => tareasEmpleado; set => tareasEmpleado = value; }
        public int EmpId { get => empId; set => empId = value; }

        public Empleados(int id){
            this.EmpId = id + 1;
            this.TareasPend = new List<Tareas>();
            this.TareasEmpleado = (int)newRandom.Next(1,4);
        }

        public void AddData(){
            for(int i = 0; i < this.TareasEmpleado; i++){
                this.TareasPend.Add(new Tareas());
                TareasPend[i].TareaID = i+1;
                System.Console.WriteLine("Ingrese una descripción: ");
                TareasPend[i].Descripcion = Console.ReadLine();
                System.Console.WriteLine("Duración de la tarea: ");
                TareasPend[i].Duracion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
        
        /* public void MoverTareas(){
            for(int i = 0; i < this.TareasPend.Count; i++){
                if(Preguntar()){
                    this.TareasRealz.Add(this.TareasPend[i]);
                    this.TareasPend.RemoveAt(i);
                }
            }
        } */

        public void SetHorasTrabajadas(){
            int horasR=0;
            for(int i = 0; i < this.TareasRealz.Count; i++){
                horasR += this.TareasRealz[i].Duracion;
            }
            System.Console.WriteLine($"Horas Realizadas: {horasR}");
        }
    }
}