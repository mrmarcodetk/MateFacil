namespace MateFacil
{
    partial class RegistrarProfesor
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
            this.txtIdUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btmRegistrar = new System.Windows.Forms.Button();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblDatosAlmacenados = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtCorreoPro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellidoPro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombrePro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 31);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(134, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtIdUsuario);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.btmRegistrar);
            this.panel2.Controls.Add(this.lblIdUsuario);
            this.panel2.Controls.Add(this.lblDatosAlmacenados);
            this.panel2.Controls.Add(this.lblCorreo);
            this.panel2.Controls.Add(this.lblApellido);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblpass);
            this.panel2.Controls.Add(this.txtCorreoPro);
            this.panel2.Controls.Add(this.txtApellidoPro);
            this.panel2.Controls.Add(this.txtNombrePro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 425);
            this.panel2.TabIndex = 1;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdUsuario.HintText = "Usuario";
            this.txtIdUsuario.isPassword = false;
            this.txtIdUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdUsuario.LineThickness = 3;
            this.txtIdUsuario.Location = new System.Drawing.Point(28, 29);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(288, 33);
            this.txtIdUsuario.TabIndex = 11;
            this.txtIdUsuario.Tag = "";
            this.txtIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdUsuario_KeyPress);
            this.txtIdUsuario.Leave += new System.EventHandler(this.txtIdUsuario_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Contraseña";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(26, 99);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 33);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Tag = "";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correo Electronico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre de Usuario:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(28, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(88, 17);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Contraseña:";
            // 
            // btmRegistrar
            // 
            this.btmRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(167)))));
            this.btmRegistrar.FlatAppearance.BorderSize = 0;
            this.btmRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRegistrar.ForeColor = System.Drawing.Color.White;
            this.btmRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmRegistrar.Location = new System.Drawing.Point(31, 369);
            this.btmRegistrar.Name = "btmRegistrar";
            this.btmRegistrar.Size = new System.Drawing.Size(288, 35);
            this.btmRegistrar.TabIndex = 8;
            this.btmRegistrar.Text = "Registrarse";
            this.btmRegistrar.UseVisualStyleBackColor = false;
            this.btmRegistrar.Click += new System.EventHandler(this.btmRegistrar_Click);
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblIdUsuario.Location = new System.Drawing.Point(28, 66);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(66, 17);
            this.lblIdUsuario.TabIndex = 1;
            this.lblIdUsuario.Text = "ID Usuario";
            this.lblIdUsuario.Visible = false;
            // 
            // lblDatosAlmacenados
            // 
            this.lblDatosAlmacenados.AutoSize = true;
            this.lblDatosAlmacenados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosAlmacenados.ForeColor = System.Drawing.Color.Navy;
            this.lblDatosAlmacenados.Location = new System.Drawing.Point(28, 349);
            this.lblDatosAlmacenados.Name = "lblDatosAlmacenados";
            this.lblDatosAlmacenados.Size = new System.Drawing.Size(43, 17);
            this.lblDatosAlmacenados.TabIndex = 1;
            this.lblDatosAlmacenados.Text = "Datos";
            this.lblDatosAlmacenados.Visible = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCorreo.Location = new System.Drawing.Point(28, 346);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(49, 17);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo";
            this.lblCorreo.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblApellido.Location = new System.Drawing.Point(28, 276);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellidos";
            this.lblApellido.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(28, 206);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblpass.Location = new System.Drawing.Point(28, 136);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(63, 17);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password";
            this.lblpass.Visible = false;
            // 
            // txtCorreoPro
            // 
            this.txtCorreoPro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreoPro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCorreoPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreoPro.HintForeColor = System.Drawing.Color.Empty;
            this.txtCorreoPro.HintText = "Ejemplo@MateFacil.com";
            this.txtCorreoPro.isPassword = false;
            this.txtCorreoPro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreoPro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreoPro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreoPro.LineThickness = 3;
            this.txtCorreoPro.Location = new System.Drawing.Point(28, 312);
            this.txtCorreoPro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoPro.Name = "txtCorreoPro";
            this.txtCorreoPro.Size = new System.Drawing.Size(286, 33);
            this.txtCorreoPro.TabIndex = 0;
            this.txtCorreoPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreoPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoPro_KeyPress);
            // 
            // txtApellidoPro
            // 
            this.txtApellidoPro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoPro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellidoPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoPro.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellidoPro.HintText = "Ingrese Apellidos";
            this.txtApellidoPro.isPassword = false;
            this.txtApellidoPro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoPro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoPro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoPro.LineThickness = 3;
            this.txtApellidoPro.Location = new System.Drawing.Point(28, 242);
            this.txtApellidoPro.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPro.Name = "txtApellidoPro";
            this.txtApellidoPro.Size = new System.Drawing.Size(286, 33);
            this.txtApellidoPro.TabIndex = 0;
            this.txtApellidoPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellidoPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPro_KeyPress);
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombrePro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombrePro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombrePro.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombrePro.HintText = "Ingrese Nombre";
            this.txtNombrePro.isPassword = false;
            this.txtNombrePro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombrePro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombrePro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombrePro.LineThickness = 3;
            this.txtNombrePro.Location = new System.Drawing.Point(28, 172);
            this.txtNombrePro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(286, 33);
            this.txtNombrePro.TabIndex = 0;
            this.txtNombrePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombrePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePro_KeyPress);
            // 
            // RegistrarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(358, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarProfesor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblpass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCorreoPro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoPro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombrePro;
        private System.Windows.Forms.Button btmRegistrar;
        private System.Windows.Forms.Label lblDatosAlmacenados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdUsuario;
    }
}