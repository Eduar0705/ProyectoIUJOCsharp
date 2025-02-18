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
    public partial class Inicio : Form
    {
        private Form activeForm;
        public Inicio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // No redimensionable
            this.MaximizeBox = false; // No maximizable
            this.MinimizeBox = false; // No minimizable
            this.MinimumSize = new Size(1500 ,900);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirForms(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PN_MostrarInformacion.Controls.Add(childForm);
            PN_MostrarInformacion.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void BT_GesAuditores_Click(object sender, EventArgs e)
        {
           GestionAuditores z = new GestionAuditores();
            AbrirForms(z,sender);
            label1.Text = "Gestion de Auditores";
            pictureBox2.Visible = true;
        }

        private void BT_GesSistema_Click(object sender, EventArgs e)
        {
            GestionSistemas x = new GestionSistemas();
            AbrirForms(x,sender);
            label1.Text = "Gestion de Sistemas";
            pictureBox2.Visible = true;
        }

        private void BT_GesProcesos_Click(object sender, EventArgs e)
        {
            GestionProcesos c = new GestionProcesos();
            AbrirForms(c,sender);
            label1.Text = "Gestion de Procesos";
            pictureBox2.Visible = true;
        }

        private void BT_ConsultaReportes_Click(object sender, EventArgs e)
        {
            ConsultayReportes v = new ConsultayReportes();
            AbrirForms(v,sender);
            label1.Text = "Consultas y Reportes";
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            label1.Text = "Bienvenido";
            pictureBox2.Visible = false;
        }
    }
}
