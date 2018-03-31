using System;
using System.Drawing;
using CapaNegocio;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MateFacil
{
    public partial class ProCodigoRegistro : Form
    {
        public ProCodigoRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmCodigoVerificacion_Click(object sender, EventArgs e)
        {
            CNUsuario objCodigo = new CNUsuario();
            SqlDataReader ver;
            objCodigo.CodigoVerificacion = txtVerificacion.Text;
            try
            {
                if (objCodigo.CodigoVerificacion == txtVerificacion.Text)
                {

                    lblErrorCodigoV.Visible = false;

                    ver = objCodigo.CodigoVerif();
                    if (ver.Read() == true)
                    {
                        this.Hide();
                        RegistrarProfesor objFP2 = new RegistrarProfesor();
                        objFP2.Show();
                    }
                    else
                    {
                        lblErrorNada.Text = ("Codigo invalido, intente de nuevo");
                        lblErrorNada.Visible = true;
                        txtVerificacion.Text = "";
                        txtVerificacion.Focus();
                    }
                }
                else
                {
                    lblErrorCodigoV.Text = objCodigo.CodigoVerificacion;
                    lblErrorCodigoV.Visible = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error excepcion " + ex);
            }
        }

        private void txtVerificacion_OnValueChanged(object sender, EventArgs e)
        {
            if (txtVerificacion.Text == "")
            {
                txtVerificacion.ForeColor = Color.DimGray;
                txtVerificacion.isPassword = false;
            }
        }

        private void txtVerificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
