using System;
using System.Diagnostics;
using TareasClase;
namespace EmpleadosClase{
    public class Empleados{
        private Tareas tareas;
        private List<Tareas> tareasDelEmpleado;
        private List<Tareas> tareasDelEmpleadoRealizadas;
        private int cantTareasEmp;
        private Random newRandom = new Random();
        private int empId;
        public int CanTareasEmp { get => cantTareasEmp; set => cantTareasEmp = value; }
        public int EmpId { get => empId; set => empId = value; }
        public List<Tareas> TareasDelEmpleado { get => tareasDelEmpleado; set => tareasDelEmpleado = value; }
        public List<Tareas> TareasDelEmpleadoRealizadas { get => tareasDelEmpleadoRealizadas; set => tareasDelEmpleadoRealizadas = value; }

        public Empleados(int id){
            this.EmpId = id + 1;
            this.CanTareasEmp = (int)newRandom.Next(1,4);

        }
    }
}