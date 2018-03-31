using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MateFacil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;
        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new  Alumnos());

        }
       private void Menu_Click(object sender, EventArgs e)
        {
            
        }

        private void btmAvances_Click(object sender, EventArgs e)
        {
           AbrirFormInPanel(new Avance());
        }

        private void btmLecciones_Click(object sender, EventArgs e)
        {
           AbrirFormInPanel(new Lecciones());
        }

        private void btmEjecicios_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new Ejercicios());
        }

        private void btmBaseDeDatos_Click(object sender, EventArgs e)
        {
            SubmenuBD.Visible = true;
        }

        private void Menu_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 70)
            {
                MenuVertical.Visible = false;
                MenuVertical.Width = 250;
                PanelAnimacion2.ShowSync(MenuVertical);
            }
            else
            {
                MenuVertical.Visible = false;
                MenuVertical.Width = 70;
                PanelAnimacion.ShowSync(MenuVertical);
            }
        }
    }
}
