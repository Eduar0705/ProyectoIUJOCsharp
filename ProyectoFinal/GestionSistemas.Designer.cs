namespace ProyectoFinal
{
    partial class GestionSistemas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Data_MostrarDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_Actualizar = new System.Windows.Forms.Button();
            this.BT_Incluir = new System.Windows.Forms.Button();
            this.BT_Limpiar = new System.Windows.Forms.Button();
            this.BT_Consulta = new System.Windows.Forms.Button();
            this.CHEC_NoAuditoria = new System.Windows.Forms.CheckBox();
            this.FH_Final = new System.Windows.Forms.DateTimePicker();
            this.FH_Inicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CHEC_SiAuditoria = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_DFiscal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_RifEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_NEmpresa = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_MostrarDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.groupBox2.Controls.Add(this.Data_MostrarDatos);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 287);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1214, 500);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Almacenados";
            // 
            // Data_MostrarDatos
            // 
            this.Data_MostrarDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.Data_MostrarDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_MostrarDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Data_MostrarDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_MostrarDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Data_MostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_MostrarDatos.EnableHeadersVisualStyles = false;
            this.Data_MostrarDatos.GridColor = System.Drawing.Color.SteelBlue;
            this.Data_MostrarDatos.Location = new System.Drawing.Point(18, 29);
            this.Data_MostrarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.Data_MostrarDatos.Name = "Data_MostrarDatos";
            this.Data_MostrarDatos.RowHeadersVisible = false;
            this.Data_MostrarDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Data_MostrarDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Data_MostrarDatos.RowTemplate.Height = 24;
            this.Data_MostrarDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_MostrarDatos.Size = new System.Drawing.Size(1177, 456);
            this.Data_MostrarDatos.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.CHEC_NoAuditoria);
            this.groupBox1.Controls.Add(this.FH_Final);
            this.groupBox1.Controls.Add(this.FH_Inicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CHEC_SiAuditoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXT_DFiscal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_RifEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXT_NEmpresa);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1214, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.groupBox3.Controls.Add(this.BT_Actualizar);
            this.groupBox3.Controls.Add(this.BT_Incluir);
            this.groupBox3.Controls.Add(this.BT_Limpiar);
            this.groupBox3.Controls.Add(this.BT_Consulta);
            this.groupBox3.Location = new System.Drawing.Point(1078, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 224);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // BT_Actualizar
            // 
            this.BT_Actualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Actualizar.ForeColor = System.Drawing.Color.Black;
            this.BT_Actualizar.Location = new System.Drawing.Point(17, 78);
            this.BT_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Actualizar.Name = "BT_Actualizar";
            this.BT_Actualizar.Size = new System.Drawing.Size(90, 33);
            this.BT_Actualizar.TabIndex = 21;
            this.BT_Actualizar.Text = "Actualizar";
            this.BT_Actualizar.UseVisualStyleBackColor = true;
            this.BT_Actualizar.Click += new System.EventHandler(this.BT_Actualizar_Click);
            // 
            // BT_Incluir
            // 
            this.BT_Incluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Incluir.ForeColor = System.Drawing.Color.Black;
            this.BT_Incluir.Location = new System.Drawing.Point(17, 29);
            this.BT_Incluir.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Incluir.Name = "BT_Incluir";
            this.BT_Incluir.Size = new System.Drawing.Size(90, 33);
            this.BT_Incluir.TabIndex = 20;
            this.BT_Incluir.Text = "Incluir";
            this.BT_Incluir.UseVisualStyleBackColor = true;
            this.BT_Incluir.Click += new System.EventHandler(this.BT_Incluir_Click);
            // 
            // BT_Limpiar
            // 
            this.BT_Limpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Limpiar.ForeColor = System.Drawing.Color.Black;
            this.BT_Limpiar.Location = new System.Drawing.Point(17, 175);
            this.BT_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Limpiar.Name = "BT_Limpiar";
            this.BT_Limpiar.Size = new System.Drawing.Size(90, 33);
            this.BT_Limpiar.TabIndex = 24;
            this.BT_Limpiar.Text = "Limpiar";
            this.BT_Limpiar.UseVisualStyleBackColor = true;
            this.BT_Limpiar.Click += new System.EventHandler(this.BT_Limpiar_Click);
            // 
            // BT_Consulta
            // 
            this.BT_Consulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Consulta.ForeColor = System.Drawing.Color.Black;
            this.BT_Consulta.Location = new System.Drawing.Point(17, 129);
            this.BT_Consulta.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Consulta.Name = "BT_Consulta";
            this.BT_Consulta.Size = new System.Drawing.Size(90, 33);
            this.BT_Consulta.TabIndex = 22;
            this.BT_Consulta.Text = "Consulta";
            this.BT_Consulta.UseVisualStyleBackColor = true;
            this.BT_Consulta.Click += new System.EventHandler(this.BT_Consulta_Click);
            // 
            // CHEC_NoAuditoria
            // 
            this.CHEC_NoAuditoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHEC_NoAuditoria.Location = new System.Drawing.Point(860, 101);
            this.CHEC_NoAuditoria.Margin = new System.Windows.Forms.Padding(2);
            this.CHEC_NoAuditoria.Name = "CHEC_NoAuditoria";
            this.CHEC_NoAuditoria.Size = new System.Drawing.Size(50, 20);
            this.CHEC_NoAuditoria.TabIndex = 25;
            this.CHEC_NoAuditoria.Text = "No";
            this.CHEC_NoAuditoria.UseVisualStyleBackColor = true;
            // 
            // FH_Final
            // 
            this.FH_Final.CalendarFont = new System.Drawing.Font("Century Gothic", 12.25F);
            this.FH_Final.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.FH_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FH_Final.Location = new System.Drawing.Point(461, 119);
            this.FH_Final.Margin = new System.Windows.Forms.Padding(2);
            this.FH_Final.Name = "FH_Final";
            this.FH_Final.Size = new System.Drawing.Size(196, 27);
            this.FH_Final.TabIndex = 19;
            // 
            // FH_Inicio
            // 
            this.FH_Inicio.CalendarFont = new System.Drawing.Font("Century Gothic", 12.25F);
            this.FH_Inicio.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.FH_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FH_Inicio.Location = new System.Drawing.Point(461, 50);
            this.FH_Inicio.Margin = new System.Windows.Forms.Padding(2);
            this.FH_Inicio.Name = "FH_Inicio";
            this.FH_Inicio.Size = new System.Drawing.Size(196, 27);
            this.FH_Inicio.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha de Inicio";
            // 
            // CHEC_SiAuditoria
            // 
            this.CHEC_SiAuditoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHEC_SiAuditoria.Location = new System.Drawing.Point(805, 101);
            this.CHEC_SiAuditoria.Margin = new System.Windows.Forms.Padding(2);
            this.CHEC_SiAuditoria.Name = "CHEC_SiAuditoria";
            this.CHEC_SiAuditoria.Size = new System.Drawing.Size(41, 20);
            this.CHEC_SiAuditoria.TabIndex = 15;
            this.CHEC_SiAuditoria.Text = "Sí";
            this.CHEC_SiAuditoria.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(801, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sistema en proceso de Auditoría";
            // 
            // TXT_DFiscal
            // 
            this.TXT_DFiscal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.TXT_DFiscal.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DFiscal.Location = new System.Drawing.Point(95, 197);
            this.TXT_DFiscal.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_DFiscal.MaxLength = 120;
            this.TXT_DFiscal.Name = "TXT_DFiscal";
            this.TXT_DFiscal.Size = new System.Drawing.Size(917, 28);
            this.TXT_DFiscal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Direción Fiscal de la Empresa";
            // 
            // TXT_RifEmpresa
            // 
            this.TXT_RifEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.TXT_RifEmpresa.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_RifEmpresa.Location = new System.Drawing.Point(96, 49);
            this.TXT_RifEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_RifEmpresa.MaxLength = 11;
            this.TXT_RifEmpresa.Name = "TXT_RifEmpresa";
            this.TXT_RifEmpresa.Size = new System.Drawing.Size(182, 28);
            this.TXT_RifEmpresa.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "RIF de la Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de la Empresa";
            // 
            // TXT_NEmpresa
            // 
            this.TXT_NEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.TXT_NEmpresa.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NEmpresa.Location = new System.Drawing.Point(96, 119);
            this.TXT_NEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_NEmpresa.MaxLength = 20;
            this.TXT_NEmpresa.Name = "TXT_NEmpresa";
            this.TXT_NEmpresa.Size = new System.Drawing.Size(182, 28);
            this.TXT_NEmpresa.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GestionSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1234, 821);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionSistemas";
            this.Text = "GestionSistemas";
            this.Load += new System.EventHandler(this.GestionSistemas_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_MostrarDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_Consulta;
        private System.Windows.Forms.Button BT_Actualizar;
        private System.Windows.Forms.Button BT_Incluir;
        private System.Windows.Forms.DateTimePicker FH_Final;
        private System.Windows.Forms.DateTimePicker FH_Inicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CHEC_SiAuditoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_DFiscal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_RifEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_NEmpresa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BT_Limpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox CHEC_NoAuditoria;
        private System.Windows.Forms.DataGridView Data_MostrarDatos;
    }
}