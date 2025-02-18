using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Auditores
    {
        //Variables de la Clase Auditores
        private string cedula;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string sexo;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private string gradoAuditor;
        private Boolean activo;
        private Int32 procesosRealizados;

        public string Cedula { get { return cedula; } set { cedula = value; } }
        public string Nombres { get { return nombres; } set { nombres = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public DateTime FechaIngreso { get { return fechaIngreso; } set { fechaIngreso = value; } }
        public string GradoAuditor { get { return gradoAuditor; } set { gradoAuditor = value; } }
        public Boolean Activo { get { return activo; } set { activo = value; } }
        public Int32 ProcesosRealizados { get { return procesosRealizados; } set { procesosRealizados = value; } }

        public Auditores()
        {
            Cedula = "#####";
            Nombres = "#####";
            Apellidos = "#####";
            Direccion = "#####";
            Sexo = "#####";
            FechaNacimiento = new DateTime(2006, 3, 18);
            FechaIngreso = new DateTime(2006, 3, 18);
            GradoAuditor = "#####";
            Activo = true;
            ProcesosRealizados = 0;
        }

        public Auditores(string If, string Sa, string Sb, string Sc, string Sd, DateTime Do, DateTime Dp, string Se, Boolean Bn, Int32 Im) 
        {
            Cedula = If;
            Nombres = Sa;
            Apellidos = Sb;
            Direccion = Sc;
            Sexo = Sd;
            FechaNacimiento = Do;
            FechaIngreso = Dp;
            GradoAuditor = Se;
            Activo = Bn;
            ProcesosRealizados = Im;
        }
    }
}
