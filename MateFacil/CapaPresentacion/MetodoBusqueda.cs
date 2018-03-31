using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
namespace MateFacil
{
    class MetodoBusqueda
    {
        CDConexion conexion = new CDConexion();
        public void Listar(DataGridView data)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("listar_registros", conexion.AbrirConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;

                data.Columns[0].Width = 100;
                data.Columns[0].HeaderCell.Value = "Id_Alumno";
                data.Columns[1].Width = 300;
                data.Columns[1].HeaderCell.Value = "Nombre_Alumno";
                data.Columns[2].Width = 100;
                data.Columns[2].HeaderCell.Value = "Grado";
                data.Columns[3].Width = 100;
                data.Columns[3].HeaderCell.Value = "Id_Grupo";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void Filtrar(DataGridView data, string buscarnombre)
        {
            try
            {
                SqlCommand sql = new SqlCommand("Filtro_BusquedaDos", conexion.AbrirConexion());
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.Add("@filtro", SqlDbType.VarChar, 200).Value = buscarnombre;

                sql.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                data.DataSource = dt;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
