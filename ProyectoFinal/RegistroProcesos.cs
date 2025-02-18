using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class RegistroProcesos
    {
        private List<Procesos> listadegestionProcesos;
        private String RutaArchivo = @"DatosDeGestionDeProcesos.txt";

        public List<Procesos> ListadeGestionProcesos { get { return listadegestionProcesos; } set { listadegestionProcesos = value; } }

        public RegistroProcesos()
        {
            ListadeGestionProcesos = new List<Procesos>();
        }
        public void AgregarProceso(Procesos proceso)
        {
            ListadeGestionProcesos.Add(proceso);
        }
        public bool ActualizarProceso(int ind, Procesos nuevoProceso)
        {
            for (int i = 0; i < ListadeGestionProcesos.Count; i++)
            {
                if (ListadeGestionProcesos[i].Posicion.Equals(ind))
                {
                    ListadeGestionProcesos[i] = nuevoProceso;
                    return true; // Devuelve true si se actualiza correctamente
                }
            }
            return false; // Devuelve false si no se encuentra el sistema
        }
        public bool EliminarProceso(int ind)
        {
            // Buscar el proceso por el índice 
            foreach (Procesos proceso in ListadeGestionProcesos)
            {
                if (proceso.Posicion.Equals(ind))
                {
                    // Eliminar el proceso de la lista
                    proceso.Activo = false;
                    return true; // Indica que se eliminó correctamente
                }
            }
            return false; // Indica que no se encontró el sistema
        }
        public Procesos ConsultarPorIndice(int ind)
        {
            foreach (Procesos proceso in ListadeGestionProcesos)
            {
                if (proceso.Posicion.Equals(ind))
                {
                    return proceso;
                }
            }
            return null; // Devuelve null si no se encuentra
        }
        public void GuardarEnArchivoTxt()
        {
            try
            {
                Int32 tamañoArchivo = ListadeGestionProcesos.Count;

                FileStream file = new FileStream(RutaArchivo, FileMode.OpenOrCreate);
                using (BinaryWriter writer = new BinaryWriter(file, Encoding.UTF8))
                {
                    writer.Write(tamañoArchivo);

                    foreach (Procesos proceso in ListadeGestionProcesos)
                    {
                        writer.Write(proceso.Posicion);

                        writer.Write(proceso.ProcesoRealizado);
                        writer.Write(proceso.AuditorRealizo);
                        writer.Write(proceso.SistemaRealizo);

                        writer.Write(proceso.FechaProceso.Day);
                        writer.Write(proceso.FechaProceso.Month);
                        writer.Write(proceso.FechaProceso.Year);

                        writer.Write(proceso.HorasUsadas);

                        writer.Write(proceso.ResultadosObtenidos);

                        writer.Write(proceso.FallasDectectadas);
                        writer.Write(proceso.Activo);
                    }
                }
                MessageBox.Show("Datos guardados en el archivo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarDesdeArchivoTxt()
        {
            try
            {
                if (!File.Exists(RutaArchivo))
                {
                    MessageBox.Show("El archivo no existe", "Mensaje");
                    return;
                }

                ListadeGestionProcesos.Clear(); // Limpiar la lista antes de cargar

                FileStream file = new FileStream(RutaArchivo, FileMode.OpenOrCreate);
                using (BinaryReader reader = new BinaryReader(file, Encoding.UTF8)) 
                {
                    Int32 tamañoArchivo = reader.ReadInt32();

                    for (int i = 0; i < tamañoArchivo; i++)
                    {
                        string Sa, Sb, Sc, Sd; Int32 Ia, Ib, Ic, Id, Ie; Boolean Ba, Bb; DateTime Da;

                        Ia = reader.ReadInt32();

                        Sa = reader.ReadString();
                        Sb = reader.ReadString();
                        Sc = reader.ReadString();

                        Ib = reader.ReadInt32();
                        Ic = reader.ReadInt32();
                        Id = reader.ReadInt32();
                        Da = new DateTime(Id, Ic, Ib);

                        Ie = reader.ReadInt32();

                        Sd = reader.ReadString();

                        Ba = reader.ReadBoolean();
                        Bb = reader.ReadBoolean();

                        Procesos proceso = new Procesos(Ia, Sa, Sb, Sc, Da, Ie, Sd, Ba, Bb);

                        ListadeGestionProcesos.Add(proceso);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
