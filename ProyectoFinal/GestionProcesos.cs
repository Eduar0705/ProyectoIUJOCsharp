using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class GestionProcesos : Form
    {
        private RegistroSistemas registrosistemas;
        private RegistroProcesos registroprocesos;
        private RegistroAuditores registroauditores;

        public GestionProcesos()
        {
            InitializeComponent();

            registrosistemas = new RegistroSistemas();
            registroprocesos = new RegistroProcesos();
            registroauditores = new RegistroAuditores();

            //Carga la lista para incluir los sistemas en el combobox del proceso
            registrosistemas.CargarDesdeArchivoTxt();
            for (int i = 0; i < registrosistemas.ListadeGestion.Count; i++)
                Combo_Sistemas.Items.Add(registrosistemas.ListadeGestion[i].Nombre_Empresa);

            //Carga la lista para incluir los auditores en el combobox del proceso
            registroauditores.CargarDesdeArchivoTxt();
            for (int i = 0; i < registroauditores.ListadeGestionAuditores.Count; i++)
            {
                if (registroauditores.ListadeGestionAuditores[i].Activo)
                    Combo_Auditores.Items.Add(registroauditores.ListadeGestionAuditores[i].Nombres + " " + registroauditores.ListadeGestionAuditores[i].Apellidos);
            }
        }

        private void LimpiarErrorrProvider()
        {
            // Limpiar errores del ErrorProvider
            errorProvider1.SetError(TXT_ProcesoRealizado, string.Empty);
            errorProvider1.SetError(Combo_Auditores, string.Empty);
            errorProvider1.SetError(Combo_Sistemas, string.Empty);
            errorProvider1.SetError(TXT_CantidadHoras, string.Empty);
            errorProvider1.SetError(FH_Proceso, string.Empty);
            errorProvider1.SetError(TXT_ResultadosObtenidos, string.Empty);
            errorProvider1.SetError(CHEC_NoFallas, string.Empty);
        }

        private bool ValidateCampos()
        {
            bool valid = true;

            // Validar Proceso
            if (string.IsNullOrWhiteSpace(TXT_ProcesoRealizado.Text))
            {
                errorProvider1.SetError(TXT_ProcesoRealizado, "Este campo no puede estar vacío.");
                valid = false;
            }
            else if (TXT_ProcesoRealizado.Text.Length < 4)
            {
                errorProvider1.SetError(TXT_ProcesoRealizado, "La descripción del proceso debe tener un mínimo de 4 caracteres.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_ProcesoRealizado, string.Empty);
            }

            // Validar ComboAuditores
            if (string.IsNullOrWhiteSpace(Combo_Auditores.Text))
            {
                errorProvider1.SetError(Combo_Auditores, "Este campo no puede estar vacío.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(Combo_Auditores, string.Empty);
            }

            // Validar ComboSistemas
            if (string.IsNullOrWhiteSpace(Combo_Sistemas.Text))
            {
                errorProvider1.SetError(Combo_Sistemas, "Este campo no puede estar vacío.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(Combo_Sistemas, string.Empty);
            }

            // Validar Cantidad de horas
            if (Convert.ToInt32(TXT_CantidadHoras.Value) <= 0)
            {
                errorProvider1.SetError(TXT_CantidadHoras, "La cantidad de horas no puede ser 0.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_CantidadHoras, string.Empty);
            }

            // Validar Fecha del proceso
            if (FH_Proceso.Value > DateTime.Now)
            {
                errorProvider1.SetError(FH_Proceso, "La fecha del proceso no puede ser mayor que la de hoy.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(FH_Proceso, string.Empty);
            }

            // Validar datos obtenidos
            if (string.IsNullOrWhiteSpace(TXT_ResultadosObtenidos.Text))
            {
                errorProvider1.SetError(TXT_ResultadosObtenidos, "Este campo no puede estar vacío.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_ResultadosObtenidos, string.Empty);
            }

            // Validar si y no
            if (!CHEC_SiFallas.Checked && !CHEC_NoFallas.Checked)
            {
                errorProvider1.SetError(CHEC_NoFallas, "Debes de selecionar una opción.");
                valid = false;
            }
            else if (CHEC_SiFallas.Checked && CHEC_NoFallas.Checked)
            {
                errorProvider1.SetError(CHEC_NoFallas, "Debes elegir una sola opción.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(CHEC_NoFallas, string.Empty);
            }

            return valid;
        }

        private void BT_Actualizar_Click(object sender, EventArgs e)
        {
            if (!ValidateCampos())
            {
                MessageBox.Show("ERROR: Complete Todos los campos del formulario.", "Mensaje de ERROR");
                return;
            }

            try
            {
                int ind = Convert.ToInt16(TXT_Indice.Text);
                Procesos nuevoProceso = new Procesos
                {
                    ProcesoRealizado = TXT_ProcesoRealizado.Text,
                    AuditorRealizo = Combo_Auditores.Text,
                    SistemaRealizo = Combo_Sistemas.Text,
                    FechaProceso = FH_Proceso.Value,
                    HorasUsadas = Convert.ToInt32(TXT_CantidadHoras.Text),
                    ResultadosObtenidos = TXT_ResultadosObtenidos.Text,
                    FallasDectectadas = CHEC_SiFallas.Checked,
                    Posicion = Convert.ToInt16(TXT_Indice.Text)
                };


                bool actualizado = registroprocesos.ActualizarProceso(ind, nuevoProceso);

                if (actualizado)
                {
                    // Guardar los datos en el archivo de texto
                    registroprocesos.GuardarEnArchivoTxt();

                    // Actualizar la fila correspondiente en el DataGridView
                    foreach (DataGridViewRow row in Data_MostrarDatosProcesos.Rows)
                    {
                        if (Convert.ToInt16(row.Cells["Índice"].Value.ToString()) == ind)
                        {
                            row.Cells["Proceso Realizado"].Value = nuevoProceso.ProcesoRealizado;
                            row.Cells["Auditor Encargado"].Value = nuevoProceso.AuditorRealizo;
                            row.Cells["Sistema Involucrado"].Value = nuevoProceso.SistemaRealizo;
                            row.Cells["Fecha Del Proceso"].Value = nuevoProceso.FechaProceso.ToShortDateString();
                            row.Cells["Cantidad De Horas Usadas"].Value = nuevoProceso.HorasUsadas.ToString();
                            row.Cells["Resultados Obtenidos"].Value = nuevoProceso.ResultadosObtenidos;
                            row.Cells["Fallas Detectadas"].Value = nuevoProceso.FallasDectectadas ? "Sí" : "No";
                            break;
                        }
                    }

                    TXT_Indice.Enabled = true;
                    LimpiarCampos(); // Limpiar los campos después de actualizar
                    MessageBox.Show("Sistema actualizado y guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna empresa con ese RIF para actualizar.", "Mensaje de búsqueda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el sistema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (Data_MostrarDatosProcesos.SelectedRows.Count > 0)
                {
                    // Mostrar un cuadro de diálogo de confirmación
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este proceso?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Obtener el índice de la fila seleccionada
                        int ind = Convert.ToInt16(Data_MostrarDatosProcesos.SelectedRows[0].Cells["Índice"].Value.ToString());
                        // Eliminar el proceso de la lista
                        bool eliminado = registroprocesos.EliminarProceso(ind);
                        if (eliminado)
                        {
                            // Eliminar la fila seleccionada del DataGridView
                            Data_MostrarDatosProcesos.Rows.Remove(Data_MostrarDatosProcesos.SelectedRows[0]);
                            // Guardar la lista en el archivo
                            registroprocesos.GuardarEnArchivoTxt();

                            MessageBox.Show("Proceso eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el Proceso con el índice especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ex.Message,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BT_Consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_Indice.Text))
            {
                MessageBox.Show("ERROR: Este campo no puede estar vacío", "Mensaje de ERROR");
                return;
            }
            int ind = Convert.ToInt16(TXT_Indice.Text);
            Procesos inf = registroprocesos.ConsultarPorIndice(ind);

            if (inf != null)
            {
                if (inf.Activo)
                {
                    TXT_ProcesoRealizado.Text = inf.ProcesoRealizado;
                    Combo_Auditores.Text = inf.AuditorRealizo;
                    Combo_Sistemas.Text = inf.SistemaRealizo;
                    FH_Proceso.Value = inf.FechaProceso;
                    TXT_CantidadHoras.Text = inf.HorasUsadas.ToString();
                    TXT_ResultadosObtenidos.Text = inf.ResultadosObtenidos;
                    CHEC_SiFallas.Checked = inf.FallasDectectadas;

                    TXT_Indice.Enabled = false;

                    if (!CHEC_SiFallas.Checked) 
                    {
                        CHEC_NoFallas.Checked = true; 
                    }

                    LimpiarErrorrProvider();
                }
                else
                {
                    MessageBox.Show("El proceso con el índice: " + ind + " no se encuentra activo.", "Mensaje de error de busqueda");
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningún proceso con ese índice", "Mensaje de error de busqueda");
            }

        }

        private void BT_Registrar_Click(object sender, EventArgs e)
        {
            if (!ValidateCampos())
            {
                MessageBox.Show("ERROR: Complete Todos los campos del formulario.", "Mensaje de ERROR");
                return;
            }

            try
            {
                Procesos w = new Procesos
                {
                    ProcesoRealizado = TXT_ProcesoRealizado.Text,
                    AuditorRealizo = Combo_Auditores.Text,
                    SistemaRealizo = Combo_Sistemas.Text,
                    FechaProceso = FH_Proceso.Value,
                    HorasUsadas = Convert.ToInt32(TXT_CantidadHoras.Text),
                    ResultadosObtenidos = TXT_ResultadosObtenidos.Text,
                    FallasDectectadas = CHEC_SiFallas.Checked,
                    Posicion = registroprocesos.ListadeGestionProcesos.Count + 1,
                    Activo = true
                };

                foreach (Auditores auditor in registroauditores.ListadeGestionAuditores)
                {
                    if (w.AuditorRealizo.Equals(auditor.Nombres + " " + auditor.Apellidos))
                    {
                        auditor.ProcesosRealizados++;
                    }
                }

                //Guarda la cantidad de procesos realizados del auditor en el txt
                registroauditores.GuardarEnArchivoTxt();

                foreach (Sistemas sistema in registrosistemas.ListadeGestion)
                {
                    if (w.SistemaRealizo.Equals(sistema.Nombre_Empresa))
                    {
                        sistema.ProcesosRealizados++;

                        if (w.FallasDectectadas)
                        {
                            sistema.FallasDetectadas++;
                        }
                    }
                }
                //Guarda cantidad de procesosRealizados y fallas detectadas en el txt
                registrosistemas.GuardarEnArchivoTxt();

                // Agregar el sistema a la lista
                registroprocesos.AgregarProceso(w);

                // Agregar una fila al DataGridView
                Data_MostrarDatosProcesos.Rows.Add(

                    w.Posicion.ToString(),
                    w.ProcesoRealizado,
                    w.AuditorRealizo,
                    w.SistemaRealizo,
                    w.FechaProceso.ToShortDateString(),
                    w.HorasUsadas.ToString(),
                    w.ResultadosObtenidos,
                    w.FallasDectectadas ? "Sí" : "No"
                );

                //Guardar en el txt
                registroprocesos.GuardarEnArchivoTxt();
                LimpiarCampos();
                LimpiarErrorrProvider();

            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto en los campos numéricos.", "Error de formato");
            }
            catch (OverflowException)
            {
                MessageBox.Show("El valor ingresado es demasiado grande o pequeño.", "Error de desbordamiento");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex, "Error");
            }
        }

        private void GestionProcesos_Load(object sender, EventArgs e)
        {
            //Aquì se establece el contenido que irá en el datagridview
            Data_MostrarDatosProcesos.ColumnCount = 8;
            Data_MostrarDatosProcesos.Columns[0].Name = "Índice";
            Data_MostrarDatosProcesos.Columns[1].Name = "Proceso Realizado";
            Data_MostrarDatosProcesos.Columns[2].Name = "Auditor Encargado";
            Data_MostrarDatosProcesos.Columns[3].Name = "Sistema Involucrado";
            Data_MostrarDatosProcesos.Columns[4].Name = "Fecha Del Proceso";
            Data_MostrarDatosProcesos.Columns[5].Name = "Cantidad De Horas Usadas";
            Data_MostrarDatosProcesos.Columns[6].Name = "Resultados Obtenidos";
            Data_MostrarDatosProcesos.Columns[7].Name = "Fallas Detectadas";

            Data_MostrarDatosProcesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_MostrarDatosProcesos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Data_MostrarDatosProcesos.MultiSelect = false;
            Data_MostrarDatosProcesos.ReadOnly = true; //para que sea solo lectura y no se pueda editar
            Data_MostrarDatosProcesos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Cargar datos desde el archivo
            registroprocesos.CargarDesdeArchivoTxt();

            // Cambiar la fuente y el tamaño de letra
            Data_MostrarDatosProcesos.DefaultCellStyle.Font = new Font("Arial", 12);
            Data_MostrarDatosProcesos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

            // Agregar los datos cargados al DataGridView
            foreach (Procesos proceso in registroprocesos.ListadeGestionProcesos)
            {
                if (proceso.Activo)
                {
                    Data_MostrarDatosProcesos.Rows.Add(
                    proceso.Posicion,
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

        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarErrorrProvider();
            LimpiarCampos();
            //TXT_Cedula.Enabled = true;
            //COMB_Nacionalidad.Enabled = true;
        }

        private void LimpiarCampos()
        {
            TXT_ProcesoRealizado.Text = string.Empty;
            Combo_Auditores.Text = string.Empty;
            Combo_Sistemas.Text = string.Empty;
            FH_Proceso.Value = DateTime.Now;
            TXT_CantidadHoras.Text = string.Empty;
            TXT_ResultadosObtenidos.Text = string.Empty;
            CHEC_SiFallas.Checked = false;
            CHEC_NoFallas.Checked = false;

            TXT_Indice.Enabled = true;
        }

        private void Combo_Auditores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Combo_Sistemas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
