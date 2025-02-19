namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_Inicio = new System.Windows.Forms.Button();
            this.BT_Salir = new System.Windows.Forms.Button();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Contra = new System.Windows.Forms.TextBox();
            this.BT_MostrarContra = new System.Windows.Forms.Button();
            this.BT_OcultalContra = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(251, 335);
            this.PanelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 226);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BT_Inicio
            // 
            this.BT_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.BT_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Inicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BT_Inicio.ForeColor = System.Drawing.Color.White;
            this.BT_Inicio.Location = new System.Drawing.Point(293, 268);
            this.BT_Inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Inicio.Name = "BT_Inicio";
            this.BT_Inicio.Size = new System.Drawing.Size(173, 39);
            this.BT_Inicio.TabIndex = 1;
            this.BT_Inicio.Text = "Iniciar Sesión";
            this.BT_Inicio.UseVisualStyleBackColor = false;
            this.BT_Inicio.Click += new System.EventHandler(this.BT_Inicio_Click);
            this.BT_Inicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Usuario_KeyDown);
            // 
            // BT_Salir
            // 
            this.BT_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.BT_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Salir.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BT_Salir.ForeColor = System.Drawing.Color.White;
            this.BT_Salir.Location = new System.Drawing.Point(593, 268);
            this.BT_Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Salir.Name = "BT_Salir";
            this.BT_Salir.Size = new System.Drawing.Size(112, 39);
            this.BT_Salir.TabIndex = 2;
            this.BT_Salir.Text = "Salir";
            this.BT_Salir.UseVisualStyleBackColor = false;
            this.BT_Salir.Click += new System.EventHandler(this.BT_Salir_Click);
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.TXT_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Usuario.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Usuario.ForeColor = System.Drawing.Color.White;
            this.TXT_Usuario.Location = new System.Drawing.Point(352, 58);
            this.TXT_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(357, 36);
            this.TXT_Usuario.TabIndex = 3;
            this.TXT_Usuario.Text = "_________________________";
            this.TXT_Usuario.Enter += new System.EventHandler(this.TXT_Usuario_Enter);
            this.TXT_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Usuario_KeyDown);
            this.TXT_Usuario.Leave += new System.EventHandler(this.TXT_Usuario_Leave);
            // 
            // TXT_Contra
            // 
            this.TXT_Contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.TXT_Contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Contra.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Contra.ForeColor = System.Drawing.Color.White;
            this.TXT_Contra.Location = new System.Drawing.Point(352, 149);
            this.TXT_Contra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_Contra.Name = "TXT_Contra";
            this.TXT_Contra.Size = new System.Drawing.Size(357, 36);
            this.TXT_Contra.TabIndex = 4;
            this.TXT_Contra.Text = "_________________________";
            this.TXT_Contra.Enter += new System.EventHandler(this.TXT_Contra_Enter);
            this.TXT_Contra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Contra_KeyDown);
            this.TXT_Contra.Leave += new System.EventHandler(this.TXT_Contra_Leave);
            // 
            // BT_MostrarContra
            // 
            this.BT_MostrarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.BT_MostrarContra.FlatAppearance.BorderSize = 0;
            this.BT_MostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MostrarContra.Image = global::ProyectoFinal.Properties.Resources.ojo__1_;
            this.BT_MostrarContra.Location = new System.Drawing.Point(731, 149);
            this.BT_MostrarContra.Name = "BT_MostrarContra";
            this.BT_MostrarContra.Size = new System.Drawing.Size(46, 35);
            this.BT_MostrarContra.TabIndex = 8;
            this.BT_MostrarContra.UseVisualStyleBackColor = false;
            this.BT_MostrarContra.Click += new System.EventHandler(this.BT_MostrarContra_Click);
            // 
            // BT_OcultalContra
            // 
            this.BT_OcultalContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.BT_OcultalContra.FlatAppearance.BorderSize = 0;
            this.BT_OcultalContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_OcultalContra.Image = global::ProyectoFinal.Properties.Resources.ojo_bizco;
            this.BT_OcultalContra.Location = new System.Drawing.Point(731, 149);
            this.BT_OcultalContra.Name = "BT_OcultalContra";
            this.BT_OcultalContra.Size = new System.Drawing.Size(46, 35);
            this.BT_OcultalContra.TabIndex = 7;
            this.BT_OcultalContra.UseVisualStyleBackColor = false;
            this.BT_OcultalContra.Visible = false;
            this.BT_OcultalContra.Click += new System.EventHandler(this.BT_OcultalContra_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(288, 126);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 49);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProyectoFinal.Properties.Resources.usuarios;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(289, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.BT_MostrarContra);
            this.Controls.Add(this.BT_OcultalContra);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TXT_Contra);
            this.Controls.Add(this.TXT_Usuario);
            this.Controls.Add(this.BT_Salir);
            this.Controls.Add(this.BT_Inicio);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button BT_Inicio;
        private System.Windows.Forms.Button BT_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Contra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BT_OcultalContra;
        private System.Windows.Forms.Button BT_MostrarContra;
    }
}

