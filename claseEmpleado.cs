using System;
using System.Diagnostics;

namespace EmpleadosClase
{
    class Empleado{
        public Empleado(){
            this.tareaID = 0;
            this.descripcion = "";
            this.duracion = 0;
        }
        public Empleado(int tID, string descp, int dur){
            this.tareaID = tID;
            this.descripcion = descp;
            this.duracion = dur;
        }
        private int tareaID;
        private string descripcion;
        private int duracion;

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
    }
}