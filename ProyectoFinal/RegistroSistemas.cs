using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text;

namespace ProyectoFinal
{
    public class RegistroSistemas
    {
        private List<Sistemas> listadegestion;
        private String rutaArchivo = @"DatosdeGestionDeSistemas.txt";
        public List<Sistemas> ListadeGestion { get { return listadegestion; } set { listadegestion = value; } }

        public RegistroSistemas()
        {
            ListadeGestion = new List<Sistemas>();
        }
        
        // Método para verificar si un RIF ya existe
        public bool VerificarRifExistente(string rifEmpresa)
        {
            foreach (Sistemas sistema in ListadeGestion)
            {
                if (sistema.Rif_Empresa.Equals(rifEmpresa, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // El RIF ya existe
                }
            }
            return false; // El RIF no existe
        }

        // Método para agregar un sistema
        public void AgregarSistema(Sistemas sistema)
        {
            if (VerificarRifExistente(sistema.Rif_Empresa))
            {
                MessageBox.Show("El RIF ya existe. No se puede agregar el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListadeGestion.Add(sistema);
                MessageBox.Show("Sistema agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Sistemas ConsultarPorRif(string rifEmpresa)
        {
            foreach (Sistemas sistema in ListadeGestion)
            {
                if (sistema.Rif_Empresa.Equals(rifEmpresa))
                {
                    return sistema;
                }
            }
            return null; // Devuelve null si no se encuentra
        }

        public bool ActualizarSistema(string rifEmpresa, Sistemas nuevoSistema)
        {
            for (int i = 0; i < ListadeGestion.Count; i++)
            {
                if (ListadeGestion[i].Rif_Empresa.Equals(rifEmpresa))
                {
                    ListadeGestion[i] = nuevoSistema;
                    return true; // Devuelve true si se actualiza correctamente
                }
            }
            return false; // Devuelve false si no se encuentra el sistema
        }

        public bool EliminarSistema(string rifEmpresa)
        {
            // Buscar el sistema por el RIF 
            foreach (Sistemas sistema in ListadeGestion)
            {
                if (sistema.Rif_Empresa.Equals(rifEmpresa, StringComparison.OrdinalIgnoreCase))
                {
                    // Eliminar el sistema de la lista
                    ListadeGestion.Remove(sistema);
                    return true; // Indica que se eliminó correctamente
                }
            }
            return false; // Indica que no se encontró el sistema
        }

        // Método para cargar la lista desde un archivo de texto
        public void GuardarEnArchivoTxt()
        {
            try
            {
                Int32 tamañoArchivo = ListadeGestion.Count;

                FileStream Archivo = new FileStream(rutaArchivo, FileMode.OpenOrCreate); 

                using (BinaryWriter writer = new BinaryWriter(Archivo, Encoding.UTF8)) // Sobrescribe el archivo
                {
                    writer.Write(tamañoArchivo);

                    foreach (Sistemas sistema in ListadeGestion)
                    {

                        writer.Write(sistema.Nombre_Empresa);
                        writer.Write(sistema.Rif_Empresa);
                        writer.Write(sistema.Direccion_Fiscal);

                        writer.Write(sistema.Sistema_En_Auditoria);

                        writer.Write(sistema.Fecha_Inicio_Auditoria.Day); 
                        writer.Write(sistema.Fecha_Inicio_Auditoria.Month); 
                        writer.Write(sistema.Fecha_Inicio_Auditoria.Year); 

                        writer.Write(sistema.Fecha_Fin_Auditoria.Day); 
                        writer.Write(sistema.Fecha_Fin_Auditoria.Month); 
                        writer.Write(sistema.Fecha_Fin_Auditoria.Year);

                        writer.Write(sistema.ProcesosRealizados);
                        writer.Write(sistema.FallasDetectadas);
                        //writer.Write();
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
                if (!File.Exists(rutaArchivo)) return;

                ListadeGestion.Clear(); // Limpiar la lista antes de cargar

                FileStream Archivo = new FileStream(rutaArchivo, FileMode.Open);

                using (BinaryReader reader = new BinaryReader(Archivo, Encoding.UTF8))
                {
                    Int32 tamañoArchivo = reader.ReadInt32();

                    for(int i = 0; i < tamañoArchivo; i++)
                    {
                        string Sa, Sb, Sc; Int32 Ia, Ib, Ic, Id, Ie, If, Ih, Ii; Boolean Ba; DateTime Da, Db;

                        Sa = reader.ReadString();
                        Sb = reader.ReadString();
                        Sc = reader.ReadString();

                        Ba = reader.ReadBoolean();

                        Ia = reader.ReadInt32();
                        Ib = reader.ReadInt32();
                        Ic = reader.ReadInt32();
                        Da = new DateTime(Ic, Ib, Ia);

                        Id = reader.ReadInt32();
                        Ie = reader.ReadInt32();
                        If = reader.ReadInt32();
                        Db = new DateTime(If, Ie, Id);

                        Ih = reader.ReadInt32();
                        Ii = reader.ReadInt32();

                        Sistemas sistema = new Sistemas(Sa, Sb, Sc, Ba, Da, Db, Ih, Ii);

                        ListadeGestion.Add(sistema);

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
