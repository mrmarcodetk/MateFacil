using System;
using System.Drawing;
using CapaNegocio;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;
namespace MateFacil
{
    public partial class AgregarAlumno : Form
    {
        CDConexion conexion = new CDConexion();

        public bool Edita = false;
        public AgregarAlumno()
        {
            InitializeComponent();
            IdAlumno();
        }
        public void IdAlumno()
        {
            SqlCommand Alumno = new SqlCommand("select MAX(Id_Alumno) from Alumno", conexion.AbrirConexion());
            int i = Convert.ToInt32(Alumno.ExecuteScalar());
            conexion.CerrarConexion();
            i++;
            txtIdAlumno.Text = i.ToString();
        }
        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btmNuevoAlumno_Click(object sender, EventArgs e)
        {
            CNAlumno objAlumno = new CNAlumno();
            SqlDataReader ConfirmarGrupo;
            CDAlumno sqlrRegistrarAlumno = new CDAlumno();
            Alumnos objDato = new Alumnos();
            AgregarAlumno objCerrar = new AgregarAlumno();

            objAlumno.IdAlumno = txtIdAlumno.Text;
            objAlumno.NombreAlumno = txtNombreAlumno.Text;
            objAlumno.GrupoAlumno = txtGrupoAlumno.Text;
            objAlumno.GradoAlumno = txtGradoAlumno.Text;

            if (Edita == false)
            {
                try
                {
                    if (objAlumno.IdAlumno == txtIdAlumno.Text)
                    {
                        if (objAlumno.NombreAlumno == txtNombreAlumno.Text)
                        {
                            lblErrorNombreAlumno.Visible = false;

                            if (objAlumno.GrupoAlumno == txtGrupoAlumno.Text)
                            {
                                lblErrorGrupoAlumno.Visible = false;

                                if (objAlumno.GradoAlumno == txtGradoAlumno.Text)
                                {
                                    lblErrorGradoAlumno.Visible = false;

                                    ConfirmarGrupo = objAlumno.VerficacionDelGrupo();
                                    if (ConfirmarGrupo.Read() == true)
                                    {
                                        if (sqlrRegistrarAlumno.RegistrarAlumno(txtIdAlumno.Text, txtNombreAlumno.Text, txtGradoAlumno.Text, txtGrupoAlumno.Text))
                                        {
                                            lblRegistroAlumno.Text = "Alumno Registrado Correctamente";
                                            lblErrorGrupo.Visible = false;
                                            lblRegistroAlumno.Visible = true;
                                            txtNombreAlumno.Text = "";
                                            txtGradoAlumno.Text = "";
                                            txtGrupoAlumno.Text = "";
                                            IdAlumno();

                                        }
                                        else
                                        {
                                            lblErrorGrupo.Text = "Error de almacenamiento de datos";
                                            lblErrorGrupo.Visible = true;
                                        }
                                    }
                                    else
                                    {
                                        lblErrorGrupo.Text = "El grupo no coinside";
                                        lblErrorGrupo.Visible = true;
                                        txtGrupoAlumno.Text = "";
                                    }
                                }
                                else
                                {
                                    lblErrorGradoAlumno.Text = objAlumno.GradoAlumno;
                                    lblErrorGradoAlumno.Visible = true;
                                }
                            }
                            else
                            {
                                lblErrorGrupoAlumno.Text = objAlumno.GrupoAlumno;
                                lblErrorGrupoAlumno.Visible = true;
                            }
                        }
                        else
                        {
                            lblErrorNombreAlumno.Text = objAlumno.NombreAlumno;
                            lblErrorNombreAlumno.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error ID Alumno");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error excepcion: " + ex);
                }
            }
            
            if(Edita == true)
            {
                try
                {
                    if (objAlumno.IdAlumno == txtIdAlumno.Text)
                    {
                        if (objAlumno.NombreAlumno == txtNombreAlumno.Text)
                        {
                            lblErrorNombreAlumno.Visible = false;

                            if (objAlumno.GrupoAlumno == txtGrupoAlumno.Text)
                            {
                                lblErrorGrupoAlumno.Visible = false;

                                if (objAlumno.GradoAlumno == txtGradoAlumno.Text)
                                {
                                    lblErrorGradoAlumno.Visible = false;

                                    ConfirmarGrupo = objAlumno.VerficacionDelGrupo();
                                    if (ConfirmarGrupo.Read() == true)
                                    {
                                        if (MessageBox.Show("Desea Modificarlo ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            if (sqlrRegistrarAlumno.ModificarAlumno(txtIdAlumno.Text, txtNombreAlumno.Text, txtGradoAlumno.Text, txtGrupoAlumno.Text))
                                            {
                                                lblRegistroAlumno.Text = "Alumno Modificado Correctamente";
                                                lblErrorGrupo.Visible = false;
                                                lblRegistroAlumno.Visible = true;
                                                Edita = false;
                                                objCerrar.Close();
                                            }
                                            else
                                            {
                                                lblErrorGrupo.Text = "Error de almacenamiento de datos";
                                                lblErrorGrupo.Visible = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        lblErrorGrupo.Text = "El grupo no coinside";
                                        lblErrorGrupo.Visible = true;
                                        txtGrupoAlumno.Text = "";
                                    }
                                }
                                else
                                {
                                    lblErrorGradoAlumno.Text = objAlumno.GradoAlumno;
                                    lblErrorGradoAlumno.Visible = true;
                                }
                            }
                            else
                            {
                                lblErrorGrupoAlumno.Text = objAlumno.GrupoAlumno;
                                lblErrorGrupoAlumno.Visible = true;
                            }
                        }
                        else
                        {
                            lblErrorNombreAlumno.Text = objAlumno.NombreAlumno;
                            lblErrorNombreAlumno.Visible = true;

                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error Excepcion " +ex);
                }
            }
        }

        private void txtIdAlumno_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btmModificar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtGradoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtGrupoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
