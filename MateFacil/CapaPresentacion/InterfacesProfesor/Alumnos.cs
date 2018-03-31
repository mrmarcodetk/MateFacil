using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
using CapaNegocio;

namespace MateFacil
{
    public partial class Alumnos : Form
    {
        CDConexion conexion = new CDConexion();
        CargarDatosSQL cargar = new CargarDatosSQL();

        public Alumnos()
        {
            InitializeComponent();
            
        }
        DataSet Resultado = new DataSet();

       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new AgregarAlumno().Show();
        }

        private void dtvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            var aux = new MetodoBusqueda();
            aux.Listar(dgvAlumnos);
            cargar.CargarGrupos(dgvGrupos);
            cargar.CargarAlumnos(dgvAlumnos);

        }
        private void btmEliminar_Click(object sender, EventArgs e)
        {
            String Nombre = dgvAlumnos.CurrentRow.Cells["Nombre_Alumno"].Value.ToString();
            
            CDAlumno objEliminar = new CDAlumno();
            try
            {
                if (dgvAlumnos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Desea Eliminar a " + Nombre, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var aux = new MetodoBusqueda();
                        aux.Listar(dgvAlumnos);
                        objEliminar.EliminarAlunmo(Nombre);
                        MessageBox.Show(Nombre + " a sido Eliminado");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione la fila a Eliminar");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error excepcion " + ex);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var aux = new MetodoBusqueda();
            aux.Filtrar(dgvAlumnos, this.txtBuscar.Text.Trim());
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btmModificar_Click(object sender, EventArgs e)
        {
            AgregarAlumno objAgregar = new AgregarAlumno();

            try
            {
                if (dgvAlumnos.SelectedRows.Count > 0)
                {
                    objAgregar.txtIdAlumno.Text = dgvAlumnos.CurrentRow.Cells["Id_Alumno"].Value.ToString();
                    objAgregar.txtNombreAlumno.Text = dgvAlumnos.CurrentRow.Cells["Nombre_Alumno"].Value.ToString();
                    objAgregar.txtGradoAlumno.Text = dgvAlumnos.CurrentRow.Cells["Grado"].Value.ToString();
                    objAgregar.txtGrupoAlumno.Text = dgvAlumnos.CurrentRow.Cells["Id_Grupo"].Value.ToString();

                    objAgregar.Edita = true;
                    objAgregar.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila porfavor");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error Excepcion " + ex);
            }
        }
    }
}
