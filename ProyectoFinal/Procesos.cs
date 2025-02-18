using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Procesos
    {
        private string procesoRealizado;
        private string auditorRealizo;
        private string sistemaRealizo;
        private DateTime fechaProceso;
        private Int32 horasUsadas;
        private string resultadosObtenidos;
        private Boolean fallasDectectadas;
        private Int32 posicion;
        private Boolean activo;


        public Int32 Posicion { get { return posicion; } set { posicion = value; } }
        public string ProcesoRealizado { get { return procesoRealizado; } set { procesoRealizado = value; } }
        public string AuditorRealizo { get { return auditorRealizo; } set { auditorRealizo = value; } }
        public string SistemaRealizo { get { return sistemaRealizo; } set { sistemaRealizo = value; } }
        public DateTime FechaProceso { get { return fechaProceso; } set { fechaProceso = value; } }
        public Int32 HorasUsadas { get { return horasUsadas; } set { horasUsadas = value; } }
        public string ResultadosObtenidos { get { return resultadosObtenidos; } set { resultadosObtenidos = value; } }
        public Boolean FallasDectectadas { get { return fallasDectectadas; } set { fallasDectectadas = value; } }
        public Boolean Activo { get { return activo; } set { activo = value; } }

        public Procesos()
        {
            Posicion = 0;

            ProcesoRealizado = "#####";
            AuditorRealizo = "#####";
            SistemaRealizo = "#####";

            FechaProceso = new DateTime(2006, 3, 18);

            HorasUsadas = 0;

            ResultadosObtenidos = "#####";

            FallasDectectadas = false;
            Activo = true;
        }

        public Procesos(Int32 Ia, string Sa, string Sb, string Sc, DateTime Da, Int32 Ib, string Sd, Boolean Ba, Boolean Bb)
        {
            Posicion = Ia;

            ProcesoRealizado = Sa;
            AuditorRealizo = Sb;
            SistemaRealizo = Sc;

            FechaProceso = Da;

            HorasUsadas = Ib;

            ResultadosObtenidos = Sd;

            FallasDectectadas = Ba;
            Activo = Bb;
        }
    }
}
