using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class RegistroAuditores
    {
        private List<Auditores> listadegestionAuditores;

        private String rutaArchivo = @"DatosDeGestionDeAuditores.txt";
        public List<Auditores> ListadeGestionAuditores { get { return listadegestionAuditores; } set { listadegestionAuditores = value; } }

        public RegistroAuditores()
        {
            ListadeGestionAuditores = new List<Auditores>();
        }

        public void AgregarAuditor(Auditores otroauditor)
        {
            ListadeGestionAuditores.Add(otroauditor);

        }

        public bool VerificarCedulaExistente(string cedula)
        {
            foreach (Auditores auditor in ListadeGestionAuditores)
            {
                if (auditor.Cedula.Equals(cedula, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // El RIF ya existe
                }
            }
            return false; // El RIF no existe
        }

        public bool EliminarAuditor(string cedu)
        {
            // Buscar el auditor por el cédula
            foreach (Auditores auditor in ListadeGestionAuditores)
            {
                if (auditor.Cedula.Equals(cedu))
                {
                    // Desactiva el proceso de la lista
                    auditor.Activo = false;
                    return true; // Indica que se eliminó correctamente
                }
            }
            return false; // Indica que no se encontró el auditor
        }

        public bool ActualizarAuditor(string cedula, Auditores nuevoAuditor)
        {
            for (int i = 0; i < ListadeGestionAuditores.Count; i++)
            {
                if (ListadeGestionAuditores[i].Cedula.Equals(cedula))
                {
                    ListadeGestionAuditores[i] = nuevoAuditor;
                    return true; // Devuelve true si se actualiza correctamente
                }
            }
            return false; // Devuelve false si no se encuentra el auditor
        }

        public Auditores ConsultarPorCedula(string cedula)
        {
            foreach (Auditores auditor in ListadeGestionAuditores)
            {
                if (auditor.Cedula.Equals(cedula))
                {
                    return auditor;
                }
            }
            return null; // Devuelve null si no se encuentra
        }

        public void GuardarEnArchivoTxt()
        {
            try
            {
                Int32 tamañoArchivo = listadegestionAuditores.Count;

                FileStream Archivo = new FileStream(rutaArchivo, FileMode.OpenOrCreate);

                using (BinaryWriter writer = new BinaryWriter(Archivo, Encoding.UTF8)) // Sobrescribe el archivo
                {
                    writer.Write(tamañoArchivo);

                    foreach (Auditores auditor in ListadeGestionAuditores)
                    {
                        writer.Write(auditor.Cedula);
                        writer.Write(auditor.Nombres);
                        writer.Write(auditor.Apellidos);
                        writer.Write(auditor.Direccion);
                        writer.Write(auditor.Sexo);
                        writer.Write(auditor.FechaNacimiento.Day);
                        writer.Write(auditor.FechaNacimiento.Month);
                        writer.Write(auditor.FechaNacimiento.Year);
                        writer.Write(auditor.FechaIngreso.Day);
                        writer.Write(auditor.FechaIngreso.Month);
                        writer.Write(auditor.FechaIngreso.Year);
                        writer.Write(auditor.GradoAuditor);
                        writer.Write(auditor.Activo);
                        writer.Write(auditor.ProcesosRealizados); 
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
                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("El archivo no existe", "Mensaje");
                    return;
                }
                
                ListadeGestionAuditores.Clear(); // Limpiar la lista antes de cargar

                FileStream archivo = new FileStream(rutaArchivo, FileMode.Open);

                using (BinaryReader reader = new BinaryReader(archivo, Encoding.UTF8))
                {
                    //Aquí carga el tamaño que tenía la lista anteriormente
                    Int32 cantidadlista = reader.ReadInt32();
                    
                    for(int i = 0; i < cantidadlista; i++)
                    {           
                        string Sa, Sb, Sc, Sd, Se, If; Int32 Ig, Ih, Ii, Ij, Ik, Il, Im; Boolean Bn; DateTime Do, Dp;

                        If = reader.ReadString();
                        Sa = reader.ReadString();
                        Sb = reader.ReadString();
                        Sc = reader.ReadString();
                        Sd = reader.ReadString();

                        Ig = reader.ReadInt32();
                        Ih = reader.ReadInt32();
                        Ii = reader.ReadInt32();
                        Do = new DateTime(Ii, Ih, Ig);
                             
                        Ij = reader.ReadInt32();
                        Ik = reader.ReadInt32();
                        Il = reader.ReadInt32();
                        Dp = new DateTime(Il, Ik, Ij);

                        Se = reader.ReadString();

                        Bn = reader.ReadBoolean();

                        Im = reader.ReadInt32();

                        Auditores auditor = new Auditores(If, Sa, Sb, Sc, Sd, Do, Dp,  Se,  Bn,  Im);

                        ListadeGestionAuditores.Add(auditor);
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
