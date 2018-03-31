namespace MateFacil
{
    partial class IngresarProfesor
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
            this.barraDeTituloLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btmLogin = new System.Windows.Forms.Button();
            this.Contrasena = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.barraDeTituloLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraDeTituloLogin
            // 
            this.barraDeTituloLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(167)))));
            this.barraDeTituloLogin.Controls.Add(this.label4);
            this.barraDeTituloLogin.Controls.Add(this.label1);
            this.barraDeTituloLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraDeTituloLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.barraDeTituloLogin.Location = new System.Drawing.Point(0, 0);
            this.barraDeTituloLogin.Name = "barraDeTituloLogin";
            this.barraDeTituloLogin.Size = new System.Drawing.Size(450, 29);
            this.barraDeTituloLogin.TabIndex = 1;
            this.barraDeTituloLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraDeTituloLogin_MouseDown);
            this.barraDeTituloLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barraDeTituloLogin_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblErrorLogin);
            this.panel1.Controls.Add(this.lblErrorPass);
            this.panel1.Controls.Add(this.lblErrorUsuario);
            this.panel1.Controls.Add(this.lblRegistrarse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btmLogin);
            this.panel1.Controls.Add(this.Contrasena);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 221);
            this.panel1.TabIndex = 2;
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorLogin.Location = new System.Drawing.Point(71, 99);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(40, 17);
            this.lblErrorLogin.TabIndex = 9;
            this.lblErrorLogin.Text = "Login";
            this.lblErrorLogin.Visible = false;
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblErrorPass.Location = new System.Drawing.Point(71, 99);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(77, 17);
            this.lblErrorPass.TabIndex = 9;
            this.lblErrorPass.Text = "Contraseña";
            this.lblErrorPass.Visible = false;
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblErrorUsuario.Location = new System.Drawing.Point(71, 41);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(51, 17);
            this.lblErrorUsuario.TabIndex = 9;
            this.lblErrorUsuario.Text = "Usuario";
            this.lblErrorUsuario.Visible = false;
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrarse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.Location = new System.Drawing.Point(171, 195);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(76, 17);
            this.lblRegistrarse.TabIndex = 8;
            this.lblRegistrarse.Text = "Registrarse";
            this.lblRegistrarse.Click += new System.EventHandler(this.lblRegistrarse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "¿Olvido su contraseña?";
            // 
            // btmLogin
            // 
            this.btmLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(167)))));
            this.btmLogin.FlatAppearance.BorderSize = 0;
            this.btmLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLogin.ForeColor = System.Drawing.Color.White;
            this.btmLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmLogin.Location = new System.Drawing.Point(74, 119);
            this.btmLogin.Name = "btmLogin";
            this.btmLogin.Size = new System.Drawing.Size(288, 35);
            this.btmLogin.TabIndex = 7;
            this.btmLogin.Text = "Iniciar sesion";
            this.btmLogin.UseVisualStyleBackColor = false;
            this.btmLogin.Click += new System.EventHandler(this.btmLogin_Click);
            // 
            // Contrasena
            // 
            this.Contrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Contrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Contrasena.HintForeColor = System.Drawing.Color.Empty;
            this.Contrasena.HintText = "Contraseña";
            this.Contrasena.isPassword = false;
            this.Contrasena.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Contrasena.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Contrasena.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Contrasena.LineThickness = 3;
            this.Contrasena.Location = new System.Drawing.Point(74, 62);
            this.Contrasena.Margin = new System.Windows.Forms.Padding(4);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(288, 33);
            this.Contrasena.TabIndex = 0;
            this.Contrasena.Tag = "";
            this.Contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Contrasena.Enter += new System.EventHandler(this.Contrasena_Enter);
            this.Contrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contrasena_KeyPress);
            this.Contrasena.Leave += new System.EventHandler(this.Contrasena_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "Usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(74, 4);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(288, 33);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Tag = "";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.bunifuMaterialTextbox1_Leave);
            // 
            // IngresarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barraDeTituloLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarProfesor";
            this.barraDeTituloLogin.ResumeLayout(false);
            this.barraDeTituloLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barraDeTituloLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Contrasena;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorLogin;
        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.Label lblErrorUsuario;
    }
}