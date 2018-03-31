namespace MateFacil
{
    partial class ProCodigoRegistro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblErrorNada = new System.Windows.Forms.Label();
            this.lblErrorCodigoV = new System.Windows.Forms.Label();
            this.btmCodigoVerificacion = new System.Windows.Forms.Button();
            this.txtVerificacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 27);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblErrorNada);
            this.panel2.Controls.Add(this.lblErrorCodigoV);
            this.panel2.Controls.Add(this.btmCodigoVerificacion);
            this.panel2.Controls.Add(this.txtVerificacion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 122);
            this.panel2.TabIndex = 1;
            // 
            // lblErrorNada
            // 
            this.lblErrorNada.AutoSize = true;
            this.lblErrorNada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorNada.Location = new System.Drawing.Point(17, 51);
            this.lblErrorNada.Name = "lblErrorNada";
            this.lblErrorNada.Size = new System.Drawing.Size(73, 17);
            this.lblErrorNada.TabIndex = 11;
            this.lblErrorNada.Text = "Verifiacion";
            this.lblErrorNada.Visible = false;
            // 
            // lblErrorCodigoV
            // 
            this.lblErrorCodigoV.AutoSize = true;
            this.lblErrorCodigoV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCodigoV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblErrorCodigoV.Location = new System.Drawing.Point(17, 51);
            this.lblErrorCodigoV.Name = "lblErrorCodigoV";
            this.lblErrorCodigoV.Size = new System.Drawing.Size(45, 17);
            this.lblErrorCodigoV.TabIndex = 11;
            this.lblErrorCodigoV.Text = "label3";
            this.lblErrorCodigoV.Visible = false;
            // 
            // btmCodigoVerificacion
            // 
            this.btmCodigoVerificacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmCodigoVerificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(167)))));
            this.btmCodigoVerificacion.FlatAppearance.BorderSize = 0;
            this.btmCodigoVerificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmCodigoVerificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmCodigoVerificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCodigoVerificacion.ForeColor = System.Drawing.Color.White;
            this.btmCodigoVerificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmCodigoVerificacion.Location = new System.Drawing.Point(36, 71);
            this.btmCodigoVerificacion.Name = "btmCodigoVerificacion";
            this.btmCodigoVerificacion.Size = new System.Drawing.Size(186, 35);
            this.btmCodigoVerificacion.TabIndex = 10;
            this.btmCodigoVerificacion.Text = "Aceptar";
            this.btmCodigoVerificacion.UseVisualStyleBackColor = false;
            this.btmCodigoVerificacion.Click += new System.EventHandler(this.btmCodigoVerificacion_Click);
            // 
            // txtVerificacion
            // 
            this.txtVerificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVerificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerificacion.HintForeColor = System.Drawing.Color.Empty;
            this.txtVerificacion.HintText = "Codigo Verificacion";
            this.txtVerificacion.isPassword = false;
            this.txtVerificacion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerificacion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerificacion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerificacion.LineThickness = 3;
            this.txtVerificacion.Location = new System.Drawing.Point(20, 14);
            this.txtVerificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerificacion.Name = "txtVerificacion";
            this.txtVerificacion.Size = new System.Drawing.Size(236, 33);
            this.txtVerificacion.TabIndex = 9;
            this.txtVerificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVerificacion.OnValueChanged += new System.EventHandler(this.txtVerificacion_OnValueChanged);
            this.txtVerificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerificacion_KeyPress);
            // 
            // ProCodigoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(276, 149);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProCodigoRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProCodigoRegistro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btmCodigoVerificacion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVerificacion;
        private System.Windows.Forms.Label lblErrorCodigoV;
        private System.Windows.Forms.Label lblErrorNada;
    }
}