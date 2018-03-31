using System;
using System.Drawing;
using CapaNegocio;
using CapaDatos;
using System.Windows.Forms;

namespace MateFacil
{
    public partial class RegistrarProfesor : Form
    {
        public RegistrarProfesor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmRegistrar_Click(object sender, EventArgs e)
        {
            CNUsuario objRegistrar = new CNUsuario();
            CDUsuarios sql = new CDUsuarios();

            objRegistrar.IDUsuario = txtIdUsuario.Text;
            objRegistrar.Password = txtPassword.Text;
            objRegistrar.NombreProfesor = txtNombrePro.Text;
            objRegistrar.ApellidoProfesor = txtApellidoPro.Text;
            objRegistrar.CorreoProfesor = txtCorreoPro.Text;

            try
            {
                if (objRegistrar.IDUsuario == txtIdUsuario.Text)
                {
                    lblIdUsuario.Visible = false;

                    if (objRegistrar.Password == txtPassword.Text)
                    {
                        lblpass.Visible = false;

                        if (objRegistrar.NombreProfesor == txtNombrePro.Text)
                        {
                            lblNombre.Visible = false;

                            if (objRegistrar.ApellidoProfesor == txtApellidoPro.Text)
                            {
                                lblApellido.Visible = false;

                                if (objRegistrar.CorreoProfesor == txtCorreoPro.Text)
                                {
                                    lblCorreo.Visible = false;

                                    if (sql.RegistrarMaestro(txtIdUsuario.Text, txtPassword.Text, txtNombrePro.Text, txtApellidoPro.Text, txtCorreoPro.Text))
                                    {
                                        lblDatosAlmacenados.Text = "Datos almacenados Correctamente";
                                        lblDatosAlmacenados.Visible = true;
                                        txtIdUsuario.Text = "";
                                        txtPassword.Text = "";
                                        txtNombrePro.Text = "";
                                        txtApellidoPro.Text = "";
                                        txtCorreoPro.Text = "";
                                    }
                                    else
                                    {
                                        lblDatosAlmacenados.Text = "Error de almacenamiento de datos";
                                        lblDatosAlmacenados.Visible = true;
                                    }
                                }
                                else
                                {
                                    lblCorreo.Text = objRegistrar.CorreoProfesor;
                                    lblCorreo.Visible = true;
                                }
                            }
                            else
                            {
                                lblApellido.Text = objRegistrar.ApellidoProfesor;
                                lblApellido.Visible = true;
                            }
                        }
                        else
                        {
                            lblNombre.Text = objRegistrar.NombreProfesor;
                            lblNombre.Visible = true;
                        }
                    }
                    else
                    {
                        lblpass.Text = objRegistrar.Password;
                        lblpass.Visible = true;
                    }
                }
                else
                {
                    lblIdUsuario.Text = objRegistrar.IDUsuario;
                    lblIdUsuario.Visible = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error excepcion " + ex);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            if (txtPassword.Text == "Ingrese Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.isPassword = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Ingrese Contraseña";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.isPassword = true;

            }
        }

        private void txtIdUsuario_Leave(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "")
            {
                txtIdUsuario.Text = "Usuario";
                txtIdUsuario.ForeColor = Color.DimGray;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.LetrasYNumeros(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.LetrasYNumeros(e);
        }

        private void txtNombrePro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellidoPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtCorreoPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ArrobaYPunto(e);
        }
    }
}
