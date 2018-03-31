namespace MateFacil
{
    partial class Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btmNuevo = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.dgvGrupos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btmModificar = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(165, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos Registrados";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.Location = new System.Drawing.Point(1021, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 17);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btmNuevo
            // 
            this.btmNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btmNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btmNuevo.FlatAppearance.BorderSize = 0;
            this.btmNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmNuevo.ForeColor = System.Drawing.Color.White;
            this.btmNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btmNuevo.Image")));
            this.btmNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmNuevo.Location = new System.Drawing.Point(12, 533);
            this.btmNuevo.Name = "btmNuevo";
            this.btmNuevo.Size = new System.Drawing.Size(212, 40);
            this.btmNuevo.TabIndex = 4;
            this.btmNuevo.Text = "Nuevo";
            this.btmNuevo.UseVisualStyleBackColor = false;
            this.btmNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btmEliminar
            // 
            this.btmEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btmEliminar.FlatAppearance.BorderSize = 0;
            this.btmEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminar.ForeColor = System.Drawing.Color.White;
            this.btmEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btmEliminar.Image")));
            this.btmEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmEliminar.Location = new System.Drawing.Point(239, 533);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(212, 40);
            this.btmEliminar.TabIndex = 5;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = false;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // dgvGrupos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvGrupos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrupos.DoubleBuffered = true;
            this.dgvGrupos.EnableHeadersVisualStyles = false;
            this.dgvGrupos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvGrupos.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvGrupos.Location = new System.Drawing.Point(731, 183);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGrupos.RowHeadersVisible = false;
            this.dgvGrupos.Size = new System.Drawing.Size(207, 324);
            this.dgvGrupos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(773, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grupos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(195, 39);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(419, 19);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(79, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buscar Alumno:";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Green;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(192, 33);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(422, 32);
            this.bunifuMaterialTextbox1.TabIndex = 12;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btmModificar
            // 
            this.btmModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btmModificar.FlatAppearance.BorderSize = 0;
            this.btmModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmModificar.ForeColor = System.Drawing.Color.White;
            this.btmModificar.Image = ((System.Drawing.Image)(resources.GetObject("btmModificar.Image")));
            this.btmModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmModificar.Location = new System.Drawing.Point(466, 533);
            this.btmModificar.Name = "btmModificar";
            this.btmModificar.Size = new System.Drawing.Size(212, 40);
            this.btmModificar.TabIndex = 14;
            this.btmModificar.Text = "Modificar";
            this.btmModificar.UseVisualStyleBackColor = false;
            this.btmModificar.Click += new System.EventHandler(this.btmModificar_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.Location = new System.Drawing.Point(50, 175);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.Size = new System.Drawing.Size(601, 332);
            this.dgvAlumnos.TabIndex = 15;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btmModificar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.dgvGrupos);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.btmNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Button btmNuevo;
        private System.Windows.Forms.Button btmEliminar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgvGrupos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btmModificar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
    }
}