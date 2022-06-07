using System;
using System.Diagnostics;

namespace TareasClase
{
    public class Tareas{
        private int tareaID;
        private string descripcion;
        private int duracion;

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public Tareas(){
            
        }
        public Tareas(int tID, string descp, int dur){
            this.tareaID = tID;
            this.descripcion = descp;
            this.duracion = dur;
        }
    }
}