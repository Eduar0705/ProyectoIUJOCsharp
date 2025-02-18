using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal
{
    public partial class GestionSistemas : Form
    {
        private RegistroSistemas Funcionamiento = new RegistroSistemas();
        public GestionSistemas()
        {
            Funcionamiento = new RegistroSistemas();
            InitializeComponent();

        }

        // Método para validar el formato específico de RIF
        private bool ValidarCodigo(string codigo)
        {
            string patron = @"^J-\d+$";
            return Regex.IsMatch(codigo, patron);
        }

        //para limpiar los datos 
        private void LimpiarCampos()
        {
            TXT_NEmpresa.Text = string.Empty;
            TXT_RifEmpresa.Text = string.Empty;
            TXT_DFiscal.Text = string.Empty;
            CHEC_SiAuditoria.Checked = false;
            CHEC_NoAuditoria.Checked = false;
            FH_Inicio.Value = DateTime.Now;
            FH_Final.Value = DateTime.Now;

        }
        private void LimpiarErrorrProvider()
        {
            // Limpiar errores del ErrorProvider
            errorProvider1.SetError(TXT_NEmpresa, string.Empty);
            errorProvider1.SetError(TXT_RifEmpresa, string.Empty);
            errorProvider1.SetError(TXT_DFiscal, string.Empty);
            errorProvider1.SetError(CHEC_NoAuditoria, string.Empty);
            errorProvider1.SetError(FH_Inicio, string.Empty);
            errorProvider1.SetError(FH_Final, string.Empty);
        }
        private bool ValidateCampos()
        {
            bool valid = true;

            // Validar Rif
            if (string.IsNullOrWhiteSpace(TXT_RifEmpresa.Text))
            {
                errorProvider1.SetError(TXT_RifEmpresa, "Este campo no puede esatr vacío.");
                valid = false;
            }
            else if (!ValidarCodigo(TXT_RifEmpresa.Text))
            {
                errorProvider1.SetError(TXT_RifEmpresa, "El RIF de la empresa debe tener la forma: J-123456789.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_RifEmpresa, string.Empty);
            }

            // Validar Nombre de la empresa
            if (string.IsNullOrWhiteSpace(TXT_NEmpresa.Text))
            {
                errorProvider1.SetError(TXT_NEmpresa, "Este campo no puede estar vacío.");
                valid = false;
            }
            else if (TXT_NEmpresa.Text.Length < 4)
            {
                errorProvider1.SetError(TXT_NEmpresa, "El nombre de la empresa debe tener un mínimo de 4 caracteres.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_NEmpresa, string.Empty);
            }

            // Validar Direccion Fiscal de la empresa
            if (string.IsNullOrWhiteSpace(TXT_DFiscal.Text))
            {
                errorProvider1.SetError(TXT_DFiscal, "Este campo no puede estar vacío.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(TXT_DFiscal, string.Empty);
            }

            // Validar Fecha de inicio
            if (FH_Inicio.Value > FH_Final.Value)
            {
                errorProvider1.SetError(FH_Inicio, "La fecha inicial no puede ser mayor que la final.");
                valid = false;
            }
            else 
            {
                errorProvider1.SetError(FH_Inicio, string.Empty);
            }
            // Validar Fecha Final
            if (CHEC_NoAuditoria.Checked)
            {
                if (FH_Final.Value > DateTime.Now)
                {
                    errorProvider1.SetError(FH_Final, "La empresa no está en proceso de auditoria por lo que la fecha no puede ser mayor que la de hoy.");
                    valid = false;
                }
                else
                {
                    errorProvider1.SetError(FH_Final, string.Empty);
                }
            }
            else 
            {
                errorProvider1.SetError(FH_Final, string.Empty);
            }
            // Validar si y no
            if (!CHEC_NoAuditoria.Checked && !CHEC_SiAuditoria.Checked)
            {
                errorProvider1.SetError(CHEC_NoAuditoria, "Debes de selecionar una opción.");
                valid = false;
            }
            else if (CHEC_NoAuditoria.Checked && CHEC_SiAuditoria.Checked)
            {
                errorProvider1.SetError(CHEC_NoAuditoria, "Debes elegir una sola opción.");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(CHEC_NoAuditoria, string.Empty);
            }
            return valid;
        }
        private void BT_Consulta_Click(object sender, EventArgs e)
        {
            string riF = TXT_RifEmpresa.Text;
            if (!ValidarCodigo(riF))
            {
                MessageBox.Show("El código debe tener el formato: J-000000000.", "Error de Validación");
                return; // Salir del método si la validación falla
            }
            string rif = TXT_RifEmpresa.Text;

            Sistemas inf = Funcionamiento.ConsultarPorRif(rif);

            if (inf != null)
            {
                TXT_NEmpresa.Text = inf.Nombre_Empresa;
                TXT_RifEmpresa.Text = inf.Rif_Empresa;
                TXT_DFiscal.Text = inf.Direccion_Fiscal;
                CHEC_SiAuditoria.Checked = inf.Sistema_En_Auditoria;
                FH_Inicio.Value = inf.Fecha_Inicio_Auditoria;
                FH_Final.Value = inf.Fecha_Fin_Auditoria;

                if (!CHEC_SiAuditoria.Checked) 
                {
                    CHEC_NoAuditoria.Checked = true; 
                }

                TXT_RifEmpresa.Enabled = false;
                LimpiarErrorrProvider();
            }
            else
            {
                MessageBox.Show("No se ha encontrado ninguna Empresa con ese RIF ingresado", "Mensaje de error de busqueda");
                LimpiarErrorrProvider();
            }
        }
        private void BT_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateCampos())
                {
                    MessageBox.Show("ERROR: Complete Todos los campos del Formulario", "Mensaje de ERROR");
                    return;
                }

                string rif = TXT_RifEmpresa.Text;
                Sistemas nuevoSistema = new Sistemas
                {
                    Nombre_Empresa = TXT_NEmpresa.Text,
                    Rif_Empresa = rif,
                    Direccion_Fiscal = TXT_DFiscal.Text,
                    Sistema_En_Auditoria = CHEC_SiAuditoria.Checked,
                    Fecha_Inicio_Auditoria = FH_Inicio.Value,
                    Fecha_Fin_Auditoria = FH_Final.Value
                };

                bool actualizado = Funcionamiento.ActualizarSistema(rif, nuevoSistema);

                if (actualizado)
                {
                    // Guardar los datos en el archivo de texto
                    Funcionamiento.GuardarEnArchivoTxt();

                    // Actualizar la fila correspondiente en el DataGridView
                    foreach (DataGridViewRow row in Data_MostrarDatos.Rows)
                    {
                        if (row.Cells["RIF Empresarial"].Value.ToString() == rif)
                        {
                            row.Cells["Empresa"].Value = nuevoSistema.Nombre_Empresa;
                            row.Cells["Direccion Fiscal"].Value = nuevoSistema.Direccion_Fiscal;
                            row.Cells["Auditoria"].Value = nuevoSistema.Sistema_En_Auditoria ? "Sí" : "No";
                            row.Cells["Fecha Inicio"].Value = nuevoSistema.Fecha_Inicio_Auditoria.ToShortDateString();
                            row.Cells["Fecha Final"].Value = nuevoSistema.Fecha_Fin_Auditoria.ToShortDateString();
                            break;
                        }
                    }

                    TXT_RifEmpresa.Enabled = true;

                    LimpiarErrorrProvider();

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
        private void GestionSistemas_Load(object sender, EventArgs e)
        {
            Data_MostrarDatos.ColumnCount = 6;
            Data_MostrarDatos.Columns[0].Name = "Empresa";
            Data_MostrarDatos.Columns[1].Name = "RIF Empresarial";
            Data_MostrarDatos.Columns[2].Name = "Direccion Fiscal";
            Data_MostrarDatos.Columns[3].Name = "En Proceso De Auditoria";
            Data_MostrarDatos.Columns[4].Name = "Fecha Inicio";
            Data_MostrarDatos.Columns[5].Name = "Fecha Final";
            Data_MostrarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Data_MostrarDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Data_MostrarDatos.MultiSelect = false;
            Data_MostrarDatos.ReadOnly = true; //para que sea solo lectura y no se pueda editar

            // Cargar datos desde el archivo
            Funcionamiento.CargarDesdeArchivoTxt();

            // Cambiar la fuente y el tamaño de letra
            Data_MostrarDatos.DefaultCellStyle.Font = new Font("Arial", 12);
            Data_MostrarDatos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);


            // Agregar los datos cargados al DataGridView
            foreach (Sistemas sistema in Funcionamiento.ListadeGestion)
            {
                Data_MostrarDatos.Rows.Add(
                    sistema.Nombre_Empresa,
                    sistema.Rif_Empresa,
                    sistema.Direccion_Fiscal,
                    sistema.Sistema_En_Auditoria ? "Sí" : "No",
                    sistema.Fecha_Inicio_Auditoria.ToShortDateString(),
                    sistema.Fecha_Fin_Auditoria.ToShortDateString()
                    );
            }
        }
        private void BT_Incluir_Click(object sender, EventArgs e)
        {
            //verificación de los datos
            if (!ValidateCampos())
            {
                MessageBox.Show("ERROR: Complete Todos los campos del Formulario", "Mensaje de ERROR");
                return;
            }
            //if (!ValidateTamañoRIF())return; // Salir del método si la validación falla

            try
            {

                Sistemas w = new Sistemas
                {
                    Nombre_Empresa = TXT_NEmpresa.Text,
                    Rif_Empresa = TXT_RifEmpresa.Text,
                    Direccion_Fiscal = TXT_DFiscal.Text,
                    Sistema_En_Auditoria = CHEC_SiAuditoria.Checked,
                    Fecha_Inicio_Auditoria = FH_Inicio.Value,
                    Fecha_Fin_Auditoria = FH_Final.Value
                };

                // Verificar si el RIF ya existe antes de agregar
                if (Funcionamiento.VerificarRifExistente(w.Rif_Empresa))
                {
                    MessageBox.Show("El RIF ya existe. No se puede agregar el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Agregar el sistema a la lista
                    Funcionamiento.AgregarSistema(w);

                    // Agregar una fila al DataGridView
                    Data_MostrarDatos.Rows.Add(
                        w.Nombre_Empresa,
                        w.Rif_Empresa,
                        w.Direccion_Fiscal,
                        w.Sistema_En_Auditoria ? "Sí" : "No",
                        w.Fecha_Inicio_Auditoria.ToShortDateString(),
                        w.Fecha_Fin_Auditoria.ToShortDateString()
                    );

                    //guardar en el txt
                    Funcionamiento.GuardarEnArchivoTxt();

                    // Limpiar los campos después de guardar
                    LimpiarCampos();
                    LimpiarErrorrProvider();
                }
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

        /*private void TXT_RifEmpresa_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                string rif = TXT_RifEmpresa.Text;
                if (Funcionamiento.VerificarRifExistente(rif))
                {
                    MessageBox.Show("El RIF ya existe. Solo sirve para Actualizar informacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_RifEmpresa.Focus(); //para estar atentos que el rif ya existe y solo sirve para modificaciones
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(TXT_RifEmpresa, "ERROR al verificar el RIF");
                MessageBox.Show("Error al verificar el RIF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

       /* private bool ValidateTamañoRIF()
        {
            if (TXT_RifEmpresa.Text.Length != 11)
            {
                TXT_RifEmpresa.BackColor = System.Drawing.Color.LightCoral;
                errorProvider1.SetError(TXT_RifEmpresa, "El Rif debe ser J-123456789");
                MessageBox.Show("ERROR, El RIF debe ser J-123456789","Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // La validación falla
            }
            else
            {
                TXT_RifEmpresa.BackColor = System.Drawing.Color.White;
                errorProvider1.SetError(TXT_RifEmpresa, string.Empty);
                return true; // La validación es exitosa
            }
        }*/

        private void BT_Limpiar_Click(object sender, EventArgs e)
        {

            TXT_RifEmpresa.Enabled = true;
            LimpiarCampos();
            LimpiarErrorrProvider();
        }
    }
}