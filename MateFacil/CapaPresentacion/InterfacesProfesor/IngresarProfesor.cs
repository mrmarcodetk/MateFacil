using System;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace MateFacil
{
    public partial class IngresarProfesor : Form
    {
        public IngresarProfesor()
        {
            InitializeComponent();
        }

        private void barraDeTituloLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;

        private void barraDeTituloLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void Contrasena_Enter(object sender, EventArgs e)
        {
            if (Contrasena.Text == "Contrasena")
            {
                Contrasena.Text = "";
                Contrasena.ForeColor = Color.LightGray;
                Contrasena.isPassword = true;
            }
        }

        private void Contrasena_Leave(object sender, EventArgs e)
        {
            if (Contrasena.Text == "")
            {
                Contrasena.Text = "Contrasena";
                Contrasena.ForeColor = Color.DimGray;
                Contrasena.isPassword = false;
            }
        }

        private void btmLogin_Click(object sender, EventArgs e)
        {
            CNUsuario objUsuario = new CNUsuario();
            SqlDataReader loguear;
            objUsuario.Usuario = txtUsuario.Text;
            objUsuario.Contraseña = Contrasena.Text;

            try
            {
                if (objUsuario.Usuario == txtUsuario.Text)
                {
                    lblErrorUsuario.Visible = false;
                    lblErrorLogin.Visible = false;

                    if (objUsuario.Contraseña == Contrasena.Text)
                    {
                        lblErrorPass.Visible = false;
                        lblErrorLogin.Visible = false;

                        loguear = objUsuario.IniciarSesion();
                        if (loguear.Read() == true)
                        {
                            this.Hide();
                            Form1 objFP = new Form1();
                            objFP.Show();
                        }
                        else
                        {
                            lblErrorLogin.Text = ("Usuario o Contraseña Ivalido, Intente de nuevo");
                            lblErrorLogin.Visible = true;
                            Contrasena.Text = "";
                            Contrasena_Leave(null, e);
                            txtUsuario.Focus();
                        }
                    }
                    else
                    {
                        lblErrorPass.Text = objUsuario.Contraseña;
                        lblErrorPass.Visible = true;
                    }

                }
                else
                {
                    lblErrorUsuario.Text = objUsuario.Usuario;
                    lblErrorUsuario.Visible = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error excepcion " + ex);
            }
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            ProCodigoRegistro objCodigoPro = new ProCodigoRegistro();
            objCodigoPro.Show();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.LetrasYNumeros(e);
        }

        private void Contrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.LetrasYNumeros(e);
        }
    }
}
