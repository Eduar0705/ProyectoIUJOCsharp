namespace ProyectoFinal
{
    partial class ConsultayReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_ProcesosFecha = new System.Windows.Forms.Button();
            this.BTN_ListaSistemasAuditados = new System.Windows.Forms.Button();
            this.BTN_ProcesosAuditor = new System.Windows.Forms.Button();
            this.BTN_ListaAuditores = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridViewAuditores = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGridViewSistemasAuditados = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Combo_Auditores = new System.Windows.Forms.ComboBox();
            this.BTN_Filtrar = new System.Windows.Forms.Button();
            this.DataGridViewProcesosAuditor = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FH_RangoFinal = new System.Windows.Forms.DateTimePicker();
            this.FH_RangoInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_FIltrarFecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewProcesosFecha = new System.Windows.Forms.DataGridView();
            this.BT_Reiniciar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuditores)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSistemasAuditados)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProcesosAuditor)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProcesosFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.BTN_ProcesosFecha);
            this.panel1.Controls.Add(this.BTN_ListaSistemasAuditados);
            this.panel1.Controls.Add(this.BTN_ProcesosAuditor);
            this.panel1.Controls.Add(this.BTN_ListaAuditores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 849);
            this.panel1.TabIndex = 10;
            // 
            // BTN_ProcesosFecha
            // 
            this.BTN_ProcesosFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ProcesosFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_ProcesosFecha.FlatAppearance.BorderSize = 0;
            this.BTN_ProcesosFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ProcesosFecha.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ProcesosFecha.ForeColor = System.Drawing.Color.White;
            this.BTN_ProcesosFecha.Location = new System.Drawing.Point(0, 156);
            this.BTN_ProcesosFecha.Name = "BTN_ProcesosFecha";
            this.BTN_ProcesosFecha.Size = new System.Drawing.Size(197, 61);
            this.BTN_ProcesosFecha.TabIndex = 3;
            this.BTN_ProcesosFecha.Text = "Procesos de Auditoría por rango de Fechas";
            this.BTN_ProcesosFecha.UseVisualStyleBackColor = true;
            this.BTN_ProcesosFecha.Click += new System.EventHandler(this.BTN_ProcesosFecha_Click);
            // 
            // BTN_ListaSistemasAuditados
            // 
            this.BTN_ListaSistemasAuditados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ListaSistemasAuditados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_ListaSistemasAuditados.FlatAppearance.BorderSize = 0;
            this.BTN_ListaSistemasAuditados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ListaSistemasAuditados.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ListaSistemasAuditados.ForeColor = System.Drawing.Color.White;
            this.BTN_ListaSistemasAuditados.Location = new System.Drawing.Point(0, 96);
            this.BTN_ListaSistemasAuditados.Name = "BTN_ListaSistemasAuditados";
            this.BTN_ListaSistemasAuditados.Size = new System.Drawing.Size(197, 60);
            this.BTN_ListaSistemasAuditados.TabIndex = 2;
            this.BTN_ListaSistemasAuditados.Text = "Lista de Sistemas Auditados";
            this.BTN_ListaSistemasAuditados.UseVisualStyleBackColor = true;
            this.BTN_ListaSistemasAuditados.Click += new System.EventHandler(this.BTN_ListaSistemasAuditados_Click);
            // 
            // BTN_ProcesosAuditor
            // 
            this.BTN_ProcesosAuditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ProcesosAuditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_ProcesosAuditor.FlatAppearance.BorderSize = 0;
            this.BTN_ProcesosAuditor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ProcesosAuditor.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ProcesosAuditor.ForeColor = System.Drawing.Color.White;
            this.BTN_ProcesosAuditor.Location = new System.Drawing.Point(0, 38);
            this.BTN_ProcesosAuditor.Name = "BTN_ProcesosAuditor";
            this.BTN_ProcesosAuditor.Size = new System.Drawing.Size(197, 58);
            this.BTN_ProcesosAuditor.TabIndex = 1;
            this.BTN_ProcesosAuditor.Text = "Procesos Realizados por Auditor";
            this.BTN_ProcesosAuditor.UseVisualStyleBackColor = true;
            this.BTN_ProcesosAuditor.Click += new System.EventHandler(this.BTN_ProcesosAuditor_Click);
            // 
            // BTN_ListaAuditores
            // 
            this.BTN_ListaAuditores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ListaAuditores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_ListaAuditores.FlatAppearance.BorderSize = 0;
            this.BTN_ListaAuditores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_ListaAuditores.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ListaAuditores.ForeColor = System.Drawing.Color.White;
            this.BTN_ListaAuditores.Location = new System.Drawing.Point(0, 0);
            this.BTN_ListaAuditores.Name = "BTN_ListaAuditores";
            this.BTN_ListaAuditores.Size = new System.Drawing.Size(197, 38);
            this.BTN_ListaAuditores.TabIndex = 0;
            this.BTN_ListaAuditores.Text = "Lista de Auditores";
            this.BTN_ListaAuditores.UseVisualStyleBackColor = true;
            this.BTN_ListaAuditores.Click += new System.EventHandler(this.BTN_ListaAuditores_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(197, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1043, 849);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.tabPage1.Controls.Add(this.DataGridViewAuditores);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 814);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Auditores";
            // 
            // DataGridViewAuditores
            // 
            this.DataGridViewAuditores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.DataGridViewAuditores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewAuditores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridViewAuditores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAuditores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewAuditores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAuditores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewAuditores.EnableHeadersVisualStyles = false;
            this.DataGridViewAuditores.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridViewAuditores.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewAuditores.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewAuditores.Name = "DataGridViewAuditores";
            this.DataGridViewAuditores.RowHeadersVisible = false;
            this.DataGridViewAuditores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewAuditores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewAuditores.RowTemplate.Height = 24;
            this.DataGridViewAuditores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAuditores.Size = new System.Drawing.Size(1029, 808);
            this.DataGridViewAuditores.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.tabPage2.Controls.Add(this.DataGridViewSistemasAuditados);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1035, 814);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado de Sistemas Auditados";
            // 
            // DataGridViewSistemasAuditados
            // 
            this.DataGridViewSistemasAuditados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.DataGridViewSistemasAuditados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewSistemasAuditados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridViewSistemasAuditados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSistemasAuditados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewSistemasAuditados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSistemasAuditados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewSistemasAuditados.EnableHeadersVisualStyles = false;
            this.DataGridViewSistemasAuditados.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridViewSistemasAuditados.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewSistemasAuditados.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewSistemasAuditados.Name = "DataGridViewSistemasAuditados";
            this.DataGridViewSistemasAuditados.RowHeadersVisible = false;
            this.DataGridViewSistemasAuditados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewSistemasAuditados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewSistemasAuditados.RowTemplate.Height = 24;
            this.DataGridViewSistemasAuditados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSistemasAuditados.Size = new System.Drawing.Size(1029, 808);
            this.DataGridViewSistemasAuditados.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.DataGridViewProcesosAuditor);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1035, 814);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listado de Procesos de Auditoría realizados por Auditor";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.groupBox1.Controls.Add(this.Combo_Auditores);
            this.groupBox1.Controls.Add(this.BTN_Filtrar);
            this.groupBox1.Location = new System.Drawing.Point(669, 735);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 62);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // Combo_Auditores
            // 
            this.Combo_Auditores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Auditores.FormattingEnabled = true;
            this.Combo_Auditores.Location = new System.Drawing.Point(6, 20);
            this.Combo_Auditores.Name = "Combo_Auditores";
            this.Combo_Auditores.Size = new System.Drawing.Size(232, 29);
            this.Combo_Auditores.TabIndex = 7;
            this.Combo_Auditores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combo_Auditores_KeyPress);
            // 
            // BTN_Filtrar
            // 
            this.BTN_Filtrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Filtrar.Location = new System.Drawing.Point(259, 19);
            this.BTN_Filtrar.Name = "BTN_Filtrar";
            this.BTN_Filtrar.Size = new System.Drawing.Size(75, 31);
            this.BTN_Filtrar.TabIndex = 6;
            this.BTN_Filtrar.Text = "Filtrar";
            this.BTN_Filtrar.UseVisualStyleBackColor = true;
            this.BTN_Filtrar.Click += new System.EventHandler(this.BTN_Filtrar_Click);
            // 
            // DataGridViewProcesosAuditor
            // 
            this.DataGridViewProcesosAuditor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.DataGridViewProcesosAuditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewProcesosAuditor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridViewProcesosAuditor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProcesosAuditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewProcesosAuditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProcesosAuditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridViewProcesosAuditor.EnableHeadersVisualStyles = false;
            this.DataGridViewProcesosAuditor.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridViewProcesosAuditor.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewProcesosAuditor.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewProcesosAuditor.Name = "DataGridViewProcesosAuditor";
            this.DataGridViewProcesosAuditor.RowHeadersVisible = false;
            this.DataGridViewProcesosAuditor.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewProcesosAuditor.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewProcesosAuditor.RowTemplate.Height = 24;
            this.DataGridViewProcesosAuditor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewProcesosAuditor.Size = new System.Drawing.Size(1035, 730);
            this.DataGridViewProcesosAuditor.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.DataGridViewProcesosFecha);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1035, 814);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.groupBox3.Controls.Add(this.BT_Reiniciar);
            this.groupBox3.Controls.Add(this.FH_RangoFinal);
            this.groupBox3.Controls.Add(this.FH_RangoInicial);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.BTN_FIltrarFecha);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(258, 733);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 62);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // FH_RangoFinal
            // 
            this.FH_RangoFinal.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FH_RangoFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FH_RangoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FH_RangoFinal.Location = new System.Drawing.Point(389, 22);
            this.FH_RangoFinal.Name = "FH_RangoFinal";
            this.FH_RangoFinal.Size = new System.Drawing.Size(123, 27);
            this.FH_RangoFinal.TabIndex = 8;
            // 
            // FH_RangoInicial
            // 
            this.FH_RangoInicial.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FH_RangoInicial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FH_RangoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FH_RangoInicial.Location = new System.Drawing.Point(129, 22);
            this.FH_RangoInicial.Name = "FH_RangoInicial";
            this.FH_RangoInicial.Size = new System.Drawing.Size(124, 27);
            this.FH_RangoInicial.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rango Inicial:";
            // 
            // BTN_FIltrarFecha
            // 
            this.BTN_FIltrarFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FIltrarFecha.Location = new System.Drawing.Point(527, 20);
            this.BTN_FIltrarFecha.Name = "BTN_FIltrarFecha";
            this.BTN_FIltrarFecha.Size = new System.Drawing.Size(103, 30);
            this.BTN_FIltrarFecha.TabIndex = 9;
            this.BTN_FIltrarFecha.Text = "Filtrar";
            this.BTN_FIltrarFecha.UseVisualStyleBackColor = true;
            this.BTN_FIltrarFecha.Click += new System.EventHandler(this.BTN_FIltrarFecha_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rango Final:";
            // 
            // DataGridViewProcesosFecha
            // 
            this.DataGridViewProcesosFecha.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.DataGridViewProcesosFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewProcesosFecha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DataGridViewProcesosFecha.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProcesosFecha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewProcesosFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProcesosFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridViewProcesosFecha.EnableHeadersVisualStyles = false;
            this.DataGridViewProcesosFecha.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridViewProcesosFecha.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewProcesosFecha.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewProcesosFecha.Name = "DataGridViewProcesosFecha";
            this.DataGridViewProcesosFecha.RowHeadersVisible = false;
            this.DataGridViewProcesosFecha.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewProcesosFecha.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewProcesosFecha.RowTemplate.Height = 24;
            this.DataGridViewProcesosFecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewProcesosFecha.Size = new System.Drawing.Size(1035, 730);
            this.DataGridViewProcesosFecha.TabIndex = 11;
            // 
            // BT_Reiniciar
            // 
            this.BT_Reiniciar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Reiniciar.ForeColor = System.Drawing.Color.Black;
            this.BT_Reiniciar.Location = new System.Drawing.Point(648, 20);
            this.BT_Reiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Reiniciar.Name = "BT_Reiniciar";
            this.BT_Reiniciar.Size = new System.Drawing.Size(103, 30);
            this.BT_Reiniciar.TabIndex = 25;
            this.BT_Reiniciar.Text = "Reiniciar";
            this.BT_Reiniciar.UseVisualStyleBackColor = true;
            this.BT_Reiniciar.Click += new System.EventHandler(this.BT_Reiniciar_Click);
            // 
            // ConsultayReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1240, 849);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultayReportes";
            this.Text = "ConsultayReportes";
            this.Load += new System.EventHandler(this.ConsultayReportes_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuditores)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSistemasAuditados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProcesosAuditor)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProcesosFecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_ProcesosFecha;
        private System.Windows.Forms.Button BTN_ListaSistemasAuditados;
        private System.Windows.Forms.Button BTN_ProcesosAuditor;
        private System.Windows.Forms.Button BTN_ListaAuditores;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox Combo_Auditores;
        private System.Windows.Forms.Button BTN_Filtrar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_FIltrarFecha;
        private System.Windows.Forms.DateTimePicker FH_RangoFinal;
        private System.Windows.Forms.DateTimePicker FH_RangoInicial;
        private System.Windows.Forms.DataGridView DataGridViewAuditores;
        private System.Windows.Forms.DataGridView DataGridViewSistemasAuditados;
        private System.Windows.Forms.DataGridView DataGridViewProcesosAuditor;
        private System.Windows.Forms.DataGridView DataGridViewProcesosFecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_Reiniciar;
    }
}