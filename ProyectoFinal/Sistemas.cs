using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Sistemas
    {
        //Variables de la Clase de Sistemas
        private String nombreEmpresa;
        private String rifEmpresa;
        private String direccionFiscal;
        private Boolean sistemaenAuditoria;
        private DateTime fecha_Inicio;
        private DateTime fecha_Final;
        private Int32 procesosRealizados;
        private Int32 fallasDetectadas;

        public String Nombre_Empresa { get { return nombreEmpresa; } set { nombreEmpresa = value; } }
        public String Rif_Empresa { get { return rifEmpresa; } set { rifEmpresa = value; } }
        public String Direccion_Fiscal { get { return direccionFiscal; } set { direccionFiscal = value; } }
        public Boolean Sistema_En_Auditoria { get { return sistemaenAuditoria; } set { sistemaenAuditoria = value; } }
        public DateTime Fecha_Inicio_Auditoria { get { return fecha_Inicio; } set { fecha_Inicio = value; } }
        public DateTime Fecha_Fin_Auditoria { get { return fecha_Final; } set { fecha_Final = value; } }
        public Int32 ProcesosRealizados { get { return procesosRealizados; } set { procesosRealizados = value; } }
        public Int32 FallasDetectadas { get { return fallasDetectadas; } set { fallasDetectadas = value; } }

        public Sistemas()
        {

        }

        public Sistemas(string Sa, string Sb, string Sc, Boolean Ba, DateTime Da, DateTime Db, Int32 Ia, Int32 Ib )
        {
            Nombre_Empresa = Sa;
            Rif_Empresa = Sb;
            Direccion_Fiscal = Sc;

            Sistema_En_Auditoria = Ba;

            Fecha_Inicio_Auditoria = Da;
            Fecha_Fin_Auditoria = Db;

            ProcesosRealizados = Ia;
            FallasDetectadas = Ib;
        }

    }
}
