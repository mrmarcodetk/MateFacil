using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaDatos;


namespace CapaDatos
{
    class CargarDatosSQL
    {
        CDConexion conexion = new CDConexion();
        DataTable dt;
        SqlDataAdapter da;
        public void CargarGrupos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Datos_Grupo", conexion.AbrirConexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorm dataGridview: " + ex.ToString());
            }
        }
        public void CargarAlumnos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Alumno", conexion.AbrirConexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorm dataGridview: " + ex.ToString());
            }
        }
    }
}
