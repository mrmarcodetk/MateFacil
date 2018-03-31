namespace MateFacil
{
    partial class Lecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecciones));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btmAgregarLeccion = new System.Windows.Forms.Button();
            this.btmEliminarLeccion = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(412, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecciones";
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
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btmAgregarLeccion
            // 
            this.btmAgregarLeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btmAgregarLeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btmAgregarLeccion.Enabled = false;
            this.btmAgregarLeccion.FlatAppearance.BorderSize = 0;
            this.btmAgregarLeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmAgregarLeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmAgregarLeccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAgregarLeccion.ForeColor = System.Drawing.Color.White;
            this.btmAgregarLeccion.Image = ((System.Drawing.Image)(resources.GetObject("btmAgregarLeccion.Image")));
            this.btmAgregarLeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmAgregarLeccion.Location = new System.Drawing.Point(198, 548);
            this.btmAgregarLeccion.Name = "btmAgregarLeccion";
            this.btmAgregarLeccion.Size = new System.Drawing.Size(212, 40);
            this.btmAgregarLeccion.TabIndex = 9;
            this.btmAgregarLeccion.Text = "Agregar Leccion";
            this.btmAgregarLeccion.UseVisualStyleBackColor = false;
            this.btmAgregarLeccion.Visible = false;
            // 
            // btmEliminarLeccion
            // 
            this.btmEliminarLeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btmEliminarLeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btmEliminarLeccion.Enabled = false;
            this.btmEliminarLeccion.FlatAppearance.BorderSize = 0;
            this.btmEliminarLeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmEliminarLeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmEliminarLeccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminarLeccion.ForeColor = System.Drawing.Color.White;
            this.btmEliminarLeccion.Image = ((System.Drawing.Image)(resources.GetObject("btmEliminarLeccion.Image")));
            this.btmEliminarLeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmEliminarLeccion.Location = new System.Drawing.Point(542, 548);
            this.btmEliminarLeccion.Name = "btmEliminarLeccion";
            this.btmEliminarLeccion.Size = new System.Drawing.Size(212, 40);
            this.btmEliminarLeccion.TabIndex = 10;
            this.btmEliminarLeccion.Text = "Eliminar Leccion";
            this.btmEliminarLeccion.UseVisualStyleBackColor = false;
            this.btmEliminarLeccion.Visible = false;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(35, 84);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(573, 20);
            this.Buscar.TabIndex = 13;
            this.Buscar.Text = "Buscar...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(250, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Leccion";
            // 
            // Lecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmEliminarLeccion);
            this.Controls.Add(this.btmAgregarLeccion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lecciones";
            this.Text = "Lecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Button btmAgregarLeccion;
        private System.Windows.Forms.Button btmEliminarLeccion;
        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.Label label2;
    }
}