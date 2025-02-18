using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal
{
    public partial class GestionAuditores : Form
    {
        RegistroAuditores registroauditores;
        public GestionAuditores()
        {
            InitializeComponent();
            registroauditores = new RegistroAuditores();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // No redimensionable
            this.MaximizeBox = false; // No maximizable
            this.MinimizeBox = false; // No minimizable

            COMB_Sexo.Items.AddRange( new string[] { "Masculino", "Femenino" } );
            COMB_Nacionalidad.Items.AddRange( new string[] { "V", "E" } );

        }

        private void LimpiarCampos()
        {
            COMB_Nacionalidad.Text = string.Empty;
            TXT_Cedula.Text = string.Empty;
            TXT_Nombre.Text = string.Empty;
            TXT_Apellido.Text = string.Empty;
            TXT_Direccion.Text = string.Empty;
            COMB_Sexo.Text = string.Empty;
            FH_Nacimiento.Value = DateTime.Now;
            FH_Ingreso.Value = DateTime.Now;
            TXT_GradoAuditor.Text = string.Empty;
        }

        private void LimpiarErrorrProvider() 
        {
            // Limpiar errores del ErrorProvider
            errorProvider1.SetError(COMB_Nacionalidad, string.Empty);
            errorProvider1.SetError(TXT_Cedula, string.Empty);
            errorProvider1.SetError(TXT_Nombre, string.Empty);
            errorProvider1.SetError(TXT_Apellido, string.Empty);
            errorProvider1.SetError(TXT_Direccion, string.Empty);
            errorProvider1.SetError(COMB_Sexo, string.Empty);
            errorProvider1.SetError(FH_Nacimiento, string.Empty);
            errorProvider1.SetError(FH_Ingreso, string.Empty);
            errorProvider1.SetError(TXT_GradoAuditor, string.Empty);
        }
        private bool ValidateCampos()
        {
            bool valid = true;

            // Validar Nacionalidad
            if (string.IsNullOrWhiteSpace(COMB_Nacionalidad.Text))
            {
                errorProvider1.SetError(COMB_Nacionalidad, "Seleccione una nacionalidad.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(COMB_Nacionalidad, string.Empty);
            }

            // Validar Cédula
            if (string.IsNullOrWhiteSpace(TXT_Cedula.Text))
            {
                errorProvider1.SetError(TXT_Cedula, "Este campo no puede estar vacío.");
                valid = false;
            }
            else if (!ValidateCedula())
            {
                errorProvider1.SetError(TXT_Cedula, "La cédula debe tener entre 12,000,000 y 35,000,000.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_Cedula, string.Empty);
            }

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(TXT_Nombre.Text))
            {
                errorProvider1.SetError(TXT_Nombre, "Este campo no puede estar vacío.");
                valid = false;
            }
            else if (TXT_Nombre.Text.Length < 4)
            {
                errorProvider1.SetError(TXT_Nombre, "El nombre debe tener un mínimo de 4 caracteres.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_Nombre, string.Empty);
            }

            // Validar Apellido
            if (string.IsNullOrWhiteSpace(TXT_Apellido.Text))
            {
                errorProvider1.SetError(TXT_Apellido, "Este campo no puede estar vacío.");
                valid = false;
            }
            else if (TXT_Apellido.Text.Length < 4)
            {
                errorProvider1.SetError(TXT_Apellido, "El apellido debe tener un mínimo de 4 caracteres.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_Apellido, string.Empty);
            }

            // Validar Dirección
            if (string.IsNullOrWhiteSpace(TXT_Direccion.Text))
            {
                errorProvider1.SetError(TXT_Direccion, "Este campo no puede estar vacío.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_Direccion, string.Empty);
            }

            // Validar Sexo
            if (string.IsNullOrWhiteSpace(COMB_Sexo.Text))
            {
                errorProvider1.SetError(COMB_Sexo, "Seleccione un sexo.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(COMB_Sexo, string.Empty);
            }

            // Validar Fecha de Nacimiento
            if (FH_Nacimiento.Value > DateTime.Now.AddYears(-18))
            {
                errorProvider1.SetError(FH_Nacimiento, "El auditor no puede ser menor de edad.");
                valid = false;
            }
            else if (FH_Nacimiento.Value < DateTime.Now.AddYears(-60))
            {
                errorProvider1.SetError(FH_Nacimiento, "El auditor es muy mayor de edad.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(FH_Nacimiento, string.Empty);
            }

            // Validar Fecha de Ingreso
            if (FH_Ingreso.Value > DateTime.Now)
            {
                errorProvider1.SetError(FH_Ingreso, "La fecha de ingreso no puede ser mayor que la fecha actual.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(FH_Ingreso, string.Empty);
            }

            // Validar Grado del Auditor
            if (string.IsNullOrWhiteSpace(TXT_GradoAuditor.Text))
            {
                errorProvider1.SetError(TXT_GradoAuditor, "Este campo no puede estar vacío.");
                valid = false;
            }
            else if (TXT_GradoAuditor.Text.Length < 4)
            {
                errorProvider1.SetError(TXT_GradoAuditor, "El grado del auditor debe tener un mínimo de 4 caracteres.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_GradoAuditor, string.Empty);
            }
            return valid;
        }

        private bool ValidateCedula()
        {
            if (int.TryParse(TXT_Cedula.Text, out int cedula))
            {
                return cedula >= 12000000 && cedula <= 35000000;
            }
            return false;
        }

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            if (!ValidateCampos())
            {
                MessageBox.Show("ERROR: Complete todos los datos requeridos.","Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Auditores w = new Auditores
                {
                    Cedula = COMB_Nacionalidad.Text + "-" + TXT_Cedula.Text,
                    Nombres = TXT_Nombre.Text,
                    Apellidos = TXT_Apellido.Text,
                    Direccion = TXT_Direccion.Text,
                    Sexo = COMB_Sexo.Text,
                    FechaNacimiento = FH_Nacimiento.Value,
                    FechaIngreso = FH_Ingreso.Value,
                    GradoAuditor = TXT_GradoAuditor.Text,
                    Activo = true

                };

                // Verificar si la cédula ya existe antes de agregar:
                if (registroauditores.VerificarCedulaExistente(w.Cedula))
                {
                    MessageBox.Show("Advertencia: Ya existe un auditor registrado con esa cédula.", "Advertencia");
                    return;
                }

                // Agregar el auditor a la lista
                registroauditores.AgregarAuditor(w);

                // Agregar una fila al DataGridView
                Data_MostrarDatos.Rows.Add(
                    w.Cedula,
                    w.Nombres,
                    w.Apellidos,
                    w.Direccion,
                    w.Sexo,
                    w.FechaNacimiento.ToShortDateString(),
                    w.FechaIngreso.ToShortDateString(),
                    w.GradoAuditor
                );

                // Guardar en el txt
                registroauditores.GuardarEnArchivoTxt();

                // Limpiar los campos después de guardar
                LimpiarErrorrProvider();
                LimpiarCampos();
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

        private void BTN_Consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXT_Cedula.Text))
            {
                MessageBox.Show("No se ha encontrado ningún auditor con esa cédula", "Mensaje de error de busqueda");
                return;
            }

            string cedula = COMB_Nacionalidad.Text + "-" + TXT_Cedula.Text;

            Auditores inf = registroauditores.ConsultarPorCedula(cedula);

            if (inf != null)
            {
                if (inf.Activo)
                {
                    TXT_Nombre.Text = inf.Nombres;
                    TXT_Apellido.Text = inf.Apellidos;
                    TXT_Direccion.Text = inf.Direccion;
                    COMB_Sexo.Text = inf.Sexo;
                    FH_Nacimiento.Value = inf.FechaNacimiento;
                    FH_Ingreso.Value = inf.FechaIngreso;
                    TXT_GradoAuditor.Text = inf.GradoAuditor;
                    TXT_Cedula.Enabled = false;
                    COMB_Nacionalidad.Enabled = false;
                    LimpiarErrorrProvider();
                }
                else
                {
                    MessageBox.Show("El Auditor con la cédula: " + cedula + " no se encuentra activo.", "Mensaje de error de busqueda");
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningún auditor con esa cédula", "Mensaje de error de busqueda");
            }
        }
        private void BTN_Actualizar_Click(object sender, EventArgs e)
        {
            if (!ValidateCampos())
            {
                MessageBox.Show("ERROR, Complete todos los datos requeridos", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string cedula = COMB_Nacionalidad.Text + "-" + TXT_Cedula.Text;

                Auditores nuevoAuditor = new Auditores
                {
                    Cedula = cedula,
                    Nombres = TXT_Nombre.Text,
                    Apellidos = TXT_Apellido.Text,
                    Direccion = TXT_Direccion.Text,
                    Sexo = COMB_Sexo.Text,
                    FechaNacimiento = FH_Nacimiento.Value,
                    FechaIngreso = FH_Ingreso.Value,
                    GradoAuditor = TXT_GradoAuditor.Text,
                    Activo = true
                };

                bool actualizado = registroauditores.ActualizarAuditor(cedula, nuevoAuditor);

                if (actualizado)
                {
                    // Guardar los datos en el archivo de texto
                    registroauditores.GuardarEnArchivoTxt();

                    // Actualizar la fila correspondiente en el DataGridView
                    foreach (DataGridViewRow row in Data_MostrarDatos.Rows)
                    {
                        if (row.Cells["Cédula"].Value.ToString() == cedula)
                        {
                            row.Cells["Cédula"].Value = nuevoAuditor.Cedula;
                            row.Cells["Nombre"].Value = nuevoAuditor.Nombres;
                            row.Cells["Apellido"].Value = nuevoAuditor.Apellidos;
                            row.Cells["Dirección"].Value = nuevoAuditor.Direccion;
                            row.Cells["Sexo"].Value = nuevoAuditor.Sexo;
                            row.Cells["Fecha De Nacimiento"].Value = nuevoAuditor.FechaNacimiento.ToShortDateString();
                            row.Cells["Fecha De Ingreso"].Value = nuevoAuditor.FechaIngreso.ToShortDateString();
                            row.Cells["Grado Del Auditor"].Value = nuevoAuditor.GradoAuditor;
                            break;
                        }
                    }
                    LimpiarErrorrProvider();
                    LimpiarCampos(); // Limpiar los campos después de actualizar

                    TXT_Cedula.Enabled = true;
                    COMB_Nacionalidad.Enabled = true;

                    MessageBox.Show("Auditor actualizado y guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún auditor con esa cédula para actualizar.", "Mensaje de búsqueda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el auditor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            
            // Verificar si hay una fila seleccionada en el DataGridView
            if (Data_MostrarDatos.SelectedRows.Count > 0 && Data_MostrarDatos.SelectedRows[0].Cells["Cédula"].Value != null)
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este proceso?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el índice de la fila seleccionada
                    string cedula = Data_MostrarDatos.SelectedRows[0].Cells["Cédula"].Value.ToString();

                    // Eliminar el proceso de la lista
                    bool eliminado = registroauditores.EliminarAuditor(cedula);
                    if (eliminado)
                    {
                        // Eliminar la fila seleccionada del DataGridView
                        Data_MostrarDatos.Rows.Remove(Data_MostrarDatos.SelectedRows[0]);
                        // Guardar la lista en el archivo
                        registroauditores.GuardarEnArchivoTxt();

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

        private void GestionAuditores_Load(object sender, EventArgs e)
        {
            Data_MostrarDatos.ColumnCount = 8;
            Data_MostrarDatos.Columns[0].Name = "Cédula";
            Data_MostrarDatos.Columns[1].Name = "Nombre";
            Data_MostrarDatos.Columns[2].Name = "Apellido";
            Data_MostrarDatos.Columns[3].Name = "Dirección";
            Data_MostrarDatos.Columns[4].Name = "Sexo";
            Data_MostrarDatos.Columns[5].Name = "Fecha De Nacimiento";
            Data_MostrarDatos.Columns[6].Name = "Fecha De Ingreso";
            Data_MostrarDatos.Columns[7].Name = "Grado Del Auditor";

            Data_MostrarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_MostrarDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Data_MostrarDatos.MultiSelect = false;
            Data_MostrarDatos.ReadOnly = true; // Para que sea solo lectura y no se pueda editar

            // Cargar datos desde el archivo
            registroauditores.CargarDesdeArchivoTxt();

            // Cambiar la fuente y el tamaño de letra
            Data_MostrarDatos.DefaultCellStyle.Font = new Font("Arial", 12);
            Data_MostrarDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

            // Agregar los datos cargados al DataGridView
            foreach (Auditores auditor in registroauditores.ListadeGestionAuditores)
            {
                if (auditor.Activo)
                {
                    Data_MostrarDatos.Rows.Add(
                        auditor.Cedula,
                        auditor.Nombres,
                        auditor.Apellidos,
                        auditor.Direccion,
                        auditor.Sexo,
                        auditor.FechaNacimiento.ToShortDateString(),
                        auditor.FechaIngreso.ToShortDateString(),
                        auditor.GradoAuditor
                    );
                }
            }
        }

        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarErrorrProvider();
            LimpiarCampos();
            TXT_Cedula.Enabled = true;
            COMB_Nacionalidad.Enabled = true;
        }

        private void TXT_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void COMB_Nacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void TXT_GradoAuditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void COMB_Sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
 
        private void TXT_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void TXT_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
