namespace MateFacil
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.PanelAnimacion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btmAvances = new System.Windows.Forms.Button();
            this.btmBaseDeDatos = new System.Windows.Forms.Button();
            this.btmEjecicios = new System.Windows.Forms.Button();
            this.btmLecciones = new System.Windows.Forms.Button();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.SubmenuBD = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.PanelAnimacion2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelTranslacion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SubmenuBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.PanelAnimacion.SetDecoration(this.BarraTitulo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.BarraTitulo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTranslacion.SetDecoration(this.BarraTitulo, BunifuAnimatorNS.DecorationType.None);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1000, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTranslacion.SetDecoration(this.iconminimizar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.iconminimizar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.iconminimizar, BunifuAnimatorNS.DecorationType.None);
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(901, 3);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(25, 25);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 4;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTranslacion.SetDecoration(this.iconrestaurar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.iconrestaurar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.iconrestaurar, BunifuAnimatorNS.DecorationType.None);
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(932, 3);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(25, 25);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 3;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTranslacion.SetDecoration(this.iconmaximizar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.iconmaximizar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.iconmaximizar, BunifuAnimatorNS.DecorationType.None);
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(932, 3);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(25, 25);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 2;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTranslacion.SetDecoration(this.iconcerrar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.iconcerrar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.iconcerrar, BunifuAnimatorNS.DecorationType.None);
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(963, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(25, 25);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 1;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // PanelAnimacion
            // 
            this.PanelAnimacion.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.PanelAnimacion.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PanelAnimacion.DefaultAnimation = animation3;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTranslacion.SetDecoration(this.btnAlumnos, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.btnAlumnos, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.btnAlumnos, BunifuAnimatorNS.DecorationType.None);
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.Image")));
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 90);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(250, 45);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btmAvances
            // 
            this.btmAvances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTranslacion.SetDecoration(this.btmAvances, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.btmAvances, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.btmAvances, BunifuAnimatorNS.DecorationType.None);
            this.btmAvances.FlatAppearance.BorderSize = 0;
            this.btmAvances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmAvances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmAvances.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAvances.ForeColor = System.Drawing.Color.White;
            this.btmAvances.Image = ((System.Drawing.Image)(resources.GetObject("btmAvances.Image")));
            this.btmAvances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmAvances.Location = new System.Drawing.Point(-3, 169);
            this.btmAvances.Name = "btmAvances";
            this.btmAvances.Size = new System.Drawing.Size(250, 45);
            this.btmAvances.TabIndex = 0;
            this.btmAvances.Text = "Avance";
            this.btmAvances.UseVisualStyleBackColor = true;
            this.btmAvances.Click += new System.EventHandler(this.btmAvances_Click);
            // 
            // btmBaseDeDatos
            // 
            this.PanelTranslacion.SetDecoration(this.btmBaseDeDatos, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.btmBaseDeDatos, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.btmBaseDeDatos, BunifuAnimatorNS.DecorationType.None);
            this.btmBaseDeDatos.FlatAppearance.BorderSize = 0;
            this.btmBaseDeDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmBaseDeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmBaseDeDatos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBaseDeDatos.ForeColor = System.Drawing.Color.White;
            this.btmBaseDeDatos.Image = ((System.Drawing.Image)(resources.GetObject("btmBaseDeDatos.Image")));
            this.btmBaseDeDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBaseDeDatos.Location = new System.Drawing.Point(0, 396);
            this.btmBaseDeDatos.Name = "btmBaseDeDatos";
            this.btmBaseDeDatos.Size = new System.Drawing.Size(250, 45);
            this.btmBaseDeDatos.TabIndex = 0;
            this.btmBaseDeDatos.Text = "Base de datos";
            this.btmBaseDeDatos.UseVisualStyleBackColor = true;
            this.btmBaseDeDatos.Click += new System.EventHandler(this.btmBaseDeDatos_Click);
            // 
            // btmEjecicios
            // 
            this.PanelTranslacion.SetDecoration(this.btmEjecicios, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.btmEjecicios, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.btmEjecicios, BunifuAnimatorNS.DecorationType.None);
            this.btmEjecicios.FlatAppearance.BorderSize = 0;
            this.btmEjecicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmEjecicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmEjecicios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEjecicios.ForeColor = System.Drawing.Color.White;
            this.btmEjecicios.Image = ((System.Drawing.Image)(resources.GetObject("btmEjecicios.Image")));
            this.btmEjecicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmEjecicios.Location = new System.Drawing.Point(0, 319);
            this.btmEjecicios.Name = "btmEjecicios";
            this.btmEjecicios.Size = new System.Drawing.Size(250, 45);
            this.btmEjecicios.TabIndex = 0;
            this.btmEjecicios.Text = "Ejercicios";
            this.btmEjecicios.UseVisualStyleBackColor = true;
            this.btmEjecicios.Click += new System.EventHandler(this.btmEjecicios_Click);
            // 
            // btmLecciones
            // 
            this.PanelTranslacion.SetDecoration(this.btmLecciones, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.btmLecciones, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.btmLecciones, BunifuAnimatorNS.DecorationType.None);
            this.btmLecciones.FlatAppearance.BorderSize = 0;
            this.btmLecciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btmLecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLecciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLecciones.ForeColor = System.Drawing.Color.White;
            this.btmLecciones.Image = ((System.Drawing.Image)(resources.GetObject("btmLecciones.Image")));
            this.btmLecciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmLecciones.Location = new System.Drawing.Point(0, 246);
            this.btmLecciones.Name = "btmLecciones";
            this.btmLecciones.Size = new System.Drawing.Size(250, 45);
            this.btmLecciones.TabIndex = 0;
            this.btmLecciones.Text = "Lecciones";
            this.btmLecciones.UseVisualStyleBackColor = true;
            this.btmLecciones.Click += new System.EventHandler(this.btmLecciones_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(167)))));
            this.MenuVertical.Controls.Add(this.SubmenuBD);
            this.MenuVertical.Controls.Add(this.Menu);
            this.MenuVertical.Controls.Add(this.btmLecciones);
            this.MenuVertical.Controls.Add(this.btmEjecicios);
            this.MenuVertical.Controls.Add(this.btmBaseDeDatos);
            this.MenuVertical.Controls.Add(this.btmAvances);
            this.MenuVertical.Controls.Add(this.btnAlumnos);
            this.PanelAnimacion.SetDecoration(this.MenuVertical, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.MenuVertical, BunifuAnimatorNS.DecorationType.None);
            this.PanelTranslacion.SetDecoration(this.MenuVertical, BunifuAnimatorNS.DecorationType.None);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // SubmenuBD
            // 
            this.SubmenuBD.Controls.Add(this.button2);
            this.SubmenuBD.Controls.Add(this.button1);
            this.PanelAnimacion.SetDecoration(this.SubmenuBD, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.SubmenuBD, BunifuAnimatorNS.DecorationType.None);
            this.PanelTranslacion.SetDecoration(this.SubmenuBD, BunifuAnimatorNS.DecorationType.None);
            this.SubmenuBD.Location = new System.Drawing.Point(50, 447);
            this.SubmenuBD.Name = "SubmenuBD";
            this.SubmenuBD.Size = new System.Drawing.Size(200, 100);
            this.SubmenuBD.TabIndex = 2;
            this.SubmenuBD.Visible = false;
            // 
            // button2
            // 
            this.PanelTranslacion.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "Respaldar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btmBaseDeDatos_Click);
            // 
            // button1
            // 
            this.PanelTranslacion.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Restaurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btmBaseDeDatos_Click);
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTranslacion.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(192, 9);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(41, 41);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menu.TabIndex = 1;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click_1);
            // 
            // panelContenedor
            // 
            this.PanelAnimacion.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion2.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelTranslacion.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1000, 600);
            this.panelContenedor.TabIndex = 2;
            // 
            // PanelAnimacion2
            // 
            this.PanelAnimacion2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimacion2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimacion2.DefaultAnimation = animation2;
            // 
            // PanelTranslacion
            // 
            this.PanelTranslacion.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelTranslacion.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelTranslacion.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.PanelAnimacion2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimacion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelTranslacion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.SubmenuBD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private BunifuAnimatorNS.BunifuTransition PanelAnimacion;
        private BunifuAnimatorNS.BunifuTransition PanelAnimacion2;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btmAvances;
        private System.Windows.Forms.Button btmBaseDeDatos;
        private System.Windows.Forms.Button btmEjecicios;
        private System.Windows.Forms.Button btmLecciones;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private new System.Windows.Forms.PictureBox Menu;
        private BunifuAnimatorNS.BunifuTransition PanelTranslacion;
        private System.Windows.Forms.Panel SubmenuBD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

