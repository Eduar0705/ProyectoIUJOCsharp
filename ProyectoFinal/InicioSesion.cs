using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BT_Inicio.FlatStyle = FlatStyle.Flat; // Establece el estilo plano
            BT_Inicio.FlatAppearance.BorderSize = 1; // Quita el borde
            BT_Salir.FlatStyle = FlatStyle.Flat;
            BT_Salir.FlatAppearance.BorderSize = 1;
        }

        private void TXT_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_Contra.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TXT_Contra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_Inicio.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BT_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TXT_Usuario_Enter(object sender, EventArgs e)
        {
            if (TXT_Usuario.Text == "_________________________")
            {
                TXT_Usuario.Text = "";
            }
        }
        private void TXT_Usuario_Leave(object sender, EventArgs e)
        {
            if (TXT_Usuario.Text == "")
            {
                TXT_Usuario.Text = "_________________________";
            }
        }
        private void TXT_Contra_Leave(object sender, EventArgs e)
        {
            if (TXT_Contra.Text == "")
            {
                TXT_Contra.Text = "_________________________";
                TXT_Contra.UseSystemPasswordChar = false;
            }
        }
        private void TXT_Contra_Enter(object sender, EventArgs e)
        {
            if (TXT_Contra.Text == "_________________________")
            {
                TXT_Contra.Text = "";
                TXT_Contra.UseSystemPasswordChar = true;
            }
        }
        private void BT_OcultalContra_Click(object sender, EventArgs e)
        {
            TXT_Contra.UseSystemPasswordChar = true;
            BT_MostrarContra.Visible = true;
            BT_OcultalContra.Visible = false;
        }
        private void BT_MostrarContra_Click(object sender, EventArgs e)
        {
            TXT_Contra.UseSystemPasswordChar = false;
            BT_MostrarContra.Visible = false;
            BT_OcultalContra.Visible = true;
        }

        private void BT_Inicio_Click(object sender, EventArgs e)
        {
            //lee los datos del archivo txt
            string[] x = File.ReadAllLines("Datos.txt");
            string usuarioCorrecto = x[0].Trim();
            string contraseñaCorrecta = x[1].Trim();

            //variables para facilitar la busqueda
            string usuario = TXT_Usuario.Text;
            string contra = TXT_Contra.Text;

            //verificacion si esta ingresando los datos correctos
            if (usuario == usuarioCorrecto && contra == contraseñaCorrecta)
            {
                Inicio w = new Inicio();
                w.Show();
            }
            else MessageBox.Show("ERROR: Los datos ingresados son incorrectos intente de nuevo.", "ERROR de inicio");
        }
    }
}
