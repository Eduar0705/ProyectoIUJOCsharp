using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ConsultayReportes : Form
    {
        private RegistroSistemas registrosistemas;
        private RegistroProcesos registroprocesos;
        private RegistroAuditores registroauditores;
        public ConsultayReportes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // No redimensionable
            this.MaximizeBox = false; // No maximizable
            this.MinimizeBox = false; // No minimizable
            registrosistemas = new RegistroSistemas();
            registroprocesos = new RegistroProcesos();
            registroauditores = new RegistroAuditores();

            registrosistemas.CargarDesdeArchivoTxt();
            registroauditores.CargarDesdeArchivoTxt();
            registroprocesos.CargarDesdeArchivoTxt();

            Combo_Auditores.Items.Add("Todos");

            //Incluye los auditores en el combobox del proceso
            for (int i = 0; i < registroauditores.ListadeGestionAuditores.Count; i++)
                Combo_Auditores.Items.Add(registroauditores.ListadeGestionAuditores[i].Nombres + " " + registroauditores.ListadeGestionAuditores[i].Apellidos);

        }

        private void BT_Reiniciar_Click(object sender, EventArgs e)
        {
            DataGridViewProcesosFecha.Rows.Clear();

            foreach (Procesos proceso in registroprocesos.ListadeGestionProcesos)
            {
                DataGridViewProcesosFecha.Rows.Add(
                proceso.ProcesoRealizado,
                proceso.AuditorRealizo,
                proceso.SistemaRealizo,
                proceso.FechaProceso.ToShortDateString(),
                proceso.HorasUsadas.ToString(),
                proceso.ResultadosObtenidos,
                proceso.FallasDectectadas ? "Sí" : "No"
                );
            }
        }

        private void BTN_FIltrarFecha_Click(object sender, EventArgs e)
        {
            DataGridViewProcesosFecha.Rows.Clear();
            if (FH_RangoInicial.Value > FH_RangoFinal.Value) 
            {
                MessageBox.Show("Error: La fecha de inicio no puede ser mayor que la fecha incial.", "Mensaje Error");
                return;
            }
            foreach (Procesos proceso in registroprocesos.ListadeGestionProcesos)
            {
                if (proceso.FechaProceso > FH_RangoInicial.Value && proceso.FechaProceso < FH_RangoFinal.Value)
                {
                    DataGridViewProcesosFecha.Rows.Add(
                    proceso.ProcesoRealizado,
                    proceso.AuditorRealizo,
                    proceso.SistemaRealizo,
                    proceso.FechaProceso.ToShortDateString(),
                    proceso.HorasUsadas.ToString(),
                    proceso.ResultadosObtenidos,
                    proceso.FallasDectectadas ? "Sí" : "No"
                    );
                }
            }
        }

        private void BTN_Filtrar_Click(object sender, EventArgs e)
        {
            DataGridViewProcesosAuditor.Rows.Clear();

            if (Combo_Auditores.Text.Equals("Todos"))
            {
                foreach (Procesos proceso in registroprocesos.ListadeGestionProcesos)
                {
                    DataGridViewProcesosAuditor.Rows.Add(
                      proceso.ProcesoRealizado,
                      proceso.AuditorRealizo,
                      proceso.SistemaRealizo,
                      proceso.FechaProceso.ToShortDateString(),
                      proceso.HorasUsadas.ToString(),
                      proceso.ResultadosObtenidos,
                      proceso.FallasDectectadas ? "Sí" : "No"
                    );

                }
            }
            else
            {
                foreach (Procesos proceso in registroprocesos.ListadeGestionProcesos)
                {
                    if (Combo_Auditores.Text.Equals(proceso.AuditorRealizo))
                    {
                        DataGridViewProcesosAuditor.Rows.Add(
                            proceso.ProcesoRealizado,
                            proceso.AuditorRealizo,
                            proceso.SistemaRealizo,
                            proceso.FechaProceso.ToShortDateString(),
                            proceso.HorasUsadas.ToString(),
                            proceso.ResultadosObtenidos,
                            proceso.FallasDectectadas ? "Sí" : "No"
                        );
                    }
                }
            }
        }

        private void CargarDataGridViewAuditores()
        {
            DataGridViewAuditores.ColumnCount = 9;
            DataGridViewAuditores.Columns[0].Name = "Cédula";
            DataGridViewAuditores.Columns[1].Name = "Nombre";
            DataGridViewAuditores.Columns[2].Name = "Apellido";
            DataGridViewAuditores.Columns[3].Name = "Dirección";
            DataGridViewAuditores.Columns[4].Name = "Sexo";
            DataGridViewAuditores.Columns[5].Name = "Fecha De Nacimiento";
            DataGridViewAuditores.Columns[6].Name = "Fecha De Ingreso";
            DataGridViewAuditores.Columns[7].Name = "Grado Del Auditor";
            DataGridViewAuditores.Columns[8].Name = "Cantidad de Auditorias Realizadas";

            DataGridViewAuditores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewAuditores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewAuditores.MultiSelect = false;
            DataGridViewAuditores.ReadOnly = true; //para que sea solo lectura y no se pueda editar

            //Cambiar la fuente y el tamaño de letra
            DataGridViewAuditores.DefaultCellStyle.Font = new Font("Arial", 12);
            DataGridViewAuditores.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

            // Agregar los datos cargados al DataGridView

            foreach (Auditores auditor in registroauditores.ListadeGestionAuditores)
            {
                if (auditor.Activo)
                {
                    DataGridViewAuditores.Rows.Add(
                    auditor.Cedula,
                    auditor.Nombres,
                    auditor.Apellidos,
                    auditor.Direccion,
                    auditor.Sexo,
                    auditor.FechaNacimiento.ToShortDateString(),
                    auditor.FechaIngreso.ToShortDateString(),
                    auditor.GradoAuditor,
                    auditor.ProcesosRealizados.ToString()
                   );
                }
            }
        }

        private void CargarDataGridViewSistemasAuditados()
        {
            DataGridViewSistemasAuditados.ColumnCount = 3;
            DataGridViewSistemasAuditados.Columns[0].Name = "Nombre de la empresa";
            DataGridViewSistemasAuditados.Columns[1].Name = "Cantidad de procesos";
            DataGridViewSistemasAuditados.Columns[2].Name = "Fallas Detectadas";


            DataGridViewSistemasAuditados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewSistemasAuditados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewSistemasAuditados.MultiSelect = false;
            DataGridViewSistemasAuditados.ReadOnly = true; //para que sea solo lectura y no se pueda editar

            //Cargar datos desde el archivo
            registrosistemas.CargarDesdeArchivoTxt();

            //Cambiar la fuente y el tamaño de letra
            DataGridViewSistemasAuditados.DefaultCellStyle.Font = new Font("Arial", 12);
            DataGridViewSistemasAuditados.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

            // Agregar los datos cargados al DataGridView

            foreach (Sistemas sistema in registrosistemas.ListadeGestion)
            {
                if (sistema.ProcesosRealizados > 0)
                {
                    DataGridViewSistemasAuditados.Rows.Add(
                    sistema.Nombre_Empresa,
                    sistema.ProcesosRealizados.ToString(),
                    sistema.FallasDetectadas.ToString()
                    );
                }
            }
        }

        private void CargarDataGridViewProcesosAuditor()
        {
            DataGridViewProcesosAuditor.ColumnCount = 7;
            DataGridViewProcesosAuditor.Columns[0].Name = "Proceso Realizado";
            DataGridViewProcesosAuditor.Columns[1].Name = "Auditor Encargado";
            DataGridViewProcesosAuditor.Columns[2].Name = "Sistema Involucrado";
            DataGridViewProcesosAuditor.Columns[3].Name = "Fecha Del Proceso";
            DataGridViewProcesosAuditor.Columns[4].Name = "Cantidad De Horas Usadas";
            DataGridViewProcesosAuditor.Columns[5].Name = "Resultados Obtenidos";
            DataGridViewProcesosAuditor.Columns[6].Name = "Fallas Detectadas";

           
            DataGridViewProcesosAuditor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewProcesosAuditor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewProcesosAuditor.MultiSelect = false;
            DataGridViewProcesosAuditor.ReadOnly = true; //para que sea solo lectura y no se pueda editar

            // Cargar datos desde el archivo
            registroprocesos.CargarDesdeArchivoTxt();

            // Cambiar la fuente y el tamaño de letra
            DataGridViewProcesosAuditor.DefaultCellStyle.Font = new Font("Arial", 12);
            DataGridViewProcesosAuditor.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

            // Agregar los datos cargados al DataGridView

            foreach (Procesos proceso in registroprocesos.ListadeGestionProcesos)
            {
                if (proceso.Activo)
                {
                    DataGridViewProcesosAuditor.Rows.Add(
                    proceso.ProcesoRealizado,
                    proceso.AuditorRealizo,
                    proceso.SistemaRealizo,
                    proceso.FechaProceso.ToShortDateString(),
                    proceso.HorasUsadas.ToString(),
                    proceso.ResultadosObtenidos,
                    proceso.FallasDectectadas ? "Sí" : "No"
                    );
                }
            }
        }

        private void CargarDataGridViewProcesosFecha()
        {
            DataGridViewProcesosFecha.ColumnCount = 7;
            DataGridViewProcesosFecha.Columns[0].Name = "Proceso Realizado";
            DataGridViewProcesosFecha.Columns[1].Name = "Auditor Encargado";
            DataGridViewProcesosFecha.Columns[2].Name = "Sistema Involucrado";
            DataGridViewProcesosFecha.Columns[3].Name = "Fecha Del Proceso";
            DataGridViewProcesosFecha.Columns[4].Name = "Cantidad De Horas Usadas";
            DataGridViewProcesosFecha.Columns[5].Name = "Resultados Obtenidos";
            DataGridViewProcesosFecha.Columns[6].Name = "Fallas Detectadas";


            DataGridViewProcesosFecha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewProcesosFecha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewProcesosFecha.MultiSelect = false;
            DataGridViewProcesosFecha.ReadOnly = true; //para que sea solo lectura y no se pueda editar

            // Cargar datos desde el archivo
            registroprocesos.CargarDesdeArchivoTxt();

            // Cambiar la fuente y el tamaño de letra
            DataGridViewProcesosFecha.DefaultCellStyle.Font = new Font("Arial", 12);
            DataGridViewProcesosFecha.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            
            // Agregar los datos cargados al DataGridView

            foreach (Procesos proceso in registroprocesos.ListadeGestionProcesos)
            {
                if (proceso.Activo)
                {
                    DataGridViewProcesosFecha.Rows.Add(
                    proceso.ProcesoRealizado,
                    proceso.AuditorRealizo,
                    proceso.SistemaRealizo,
                    proceso.FechaProceso.ToShortDateString(),
                    proceso.HorasUsadas.ToString(),
                    proceso.ResultadosObtenidos,
                    proceso.FallasDectectadas ? "Sí" : "No"
                    );
                }
            }
        }

        private void ConsultayReportes_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            CargarDataGridViewAuditores();

            CargarDataGridViewSistemasAuditados();

            CargarDataGridViewProcesosAuditor();

            CargarDataGridViewProcesosFecha();
        }

        private void BTN_ListaAuditores_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void BTN_ProcesosAuditor_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void BTN_ListaSistemasAuditados_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void BTN_ProcesosFecha_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }
        private void Combo_Auditores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

    }
}
